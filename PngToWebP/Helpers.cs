using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PngToWebP
{
    public enum PathType
    {
        None = 0,
        File = 1,
        Directory = 2
    }
    public static class StringConstants
    {
        public const string FolderName = "PngToWebP";
        public const string RegKeyPath = "SOFTWARE\\PngToWebP";
    }

    public static class Settings
    {
        static string rootPath;
        static string cWebPPath;
        static string backupFolderName;
        static Settings()
        {
            rootPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, StringConstants.FolderName);
            cWebPPath = Path.Combine(rootPath, "cwebp.exe");
            backupFolderName = "p2w_backup";

            if (!Directory.Exists(rootPath))
            {
                Directory.CreateDirectory(rootPath);
            }
            Helpers.LoadFiles();
        }

        public static string CWebPPath
        {
            get
            {
                return cWebPPath;
            }
        }

        public static string RootPath
        {
            get
            {
                return rootPath;
            }
        }

        public static string BackupFolderName
        {
            get
            {
                return backupFolderName;
            }
        }
    }
    static class Helpers
    {
        public static string GetFileExtention(this string filePath)
        {
            string fileExtension = Path.GetExtension(filePath);
            fileExtension = string.IsNullOrWhiteSpace(fileExtension) ? fileExtension : fileExtension.ToLower();
            return fileExtension;
        }

        public static PathType GetPathType(this string path)
        {
            PathType type = PathType.None;
            if (string.IsNullOrWhiteSpace(path))
            {
                return type;
            }
            if (Directory.Exists(path))
            {
                type = PathType.Directory;
            }
            else if (File.Exists(path))
            {
                type = PathType.File;
            }
            return type;
        }

        public static List<FileInfo> GetFilesOnMultipleFilter(this  DirectoryInfo directoryInfo, string filter, SearchOption searchOption)
        {
            List<FileInfo> allFiles = new List<FileInfo>();
            string[] multipleFilters = filter.Split('|');
            foreach (string fileFilter in multipleFilters)
            {
                allFiles.AddRange(directoryInfo.GetFiles(fileFilter, searchOption).ToList());
            }
            return allFiles;
        }

        public static void GetFile(string assemblyPath, string outputPath, string fileName, bool isImage)
        {
            string filePath = Path.Combine(outputPath, fileName);
            using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(assemblyPath + fileName))
            {
                if (stream != null)
                {
                    if (isImage)
                    {
                        Image.FromStream(stream).Save(filePath);
                    }
                    else
                    {
                        if (stream.Length == 0) return;
                        // Create a FileStream object to write a stream to a file
                        using (FileStream fileStream = File.Create(filePath, (int)stream.Length))
                        {
                            // Fill the bytes[] array with the stream data
                            byte[] bytesInStream = new byte[stream.Length];
                            stream.Read(bytesInStream, 0, (int)bytesInStream.Length);

                            // Use FileStream object to write to the specified file
                            fileStream.Write(bytesInStream, 0, bytesInStream.Length);
                        }
                    }
                }
            }
        }
        public static void LoadFiles()
        {
            try
            {
                string assemblyPath = "PngToWebP.Applications.";
                string outputPath = Settings.RootPath;
                if (!File.Exists(Path.Combine(outputPath, "cwebp.exe")))
                {
                    GetFile(assemblyPath, outputPath, "cwebp.exe", false);
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
