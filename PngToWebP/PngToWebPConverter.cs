using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PngToWebP
{
    public partial class PngToWebPConverter : Form
    {
        public PngToWebPConverter()
        {
            InitializeComponent();

            ttBackup.SetToolTip(cbBackup, "Select this if you want to backup");
            ttDelete.SetToolTip(cbDelete, "Select this if you want to replace all images to webp irrespective of size.");
            ttFilter.SetToolTip(llFilter, "Mandatory if folder is selected.");
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (rbFile.Checked)
            {
                ofdFile.Filter = "Image files (*.png,*.jpg,*.jpeg,*.tiff) | *.png;*.jpg;*.jpeg;*.tiff";
                DialogResult result = ofdFile.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtPath.Text = ofdFile.FileName;
                }
            }
            else
            {
                DialogResult result = fbdFolder.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtPath.Text = fbdFolder.SelectedPath;
                }
            }
        }

        CommandProcessHandler handler;
        List<String> commands;
        private void GenerateCommands(List<FileInfo> info)
        {
            foreach (var fileInfo in info)
            {
                string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(fileInfo.FullName);
                string fileName = Path.GetFileName(fileInfo.FullName);
                string basePath = Path.GetDirectoryName(fileInfo.FullName);
                try
                {
                    if (cbBackup.Checked)
                    {
                        String backupPath = Path.Combine(basePath, Settings.BackupFolderName);
                        if (!Directory.Exists(backupPath))
                        {
                            Directory.CreateDirectory(backupPath);
                        }

                        File.Copy(fileInfo.FullName, Path.Combine(backupPath, fileName), true);
                    }
                    String newFile = Path.Combine(basePath, fileNameWithoutExtension + ".webp");
                    string commandForCompress = "\"" + Settings.CWebPPath + "\"" + " -q " + tbQuality.Value.ToString() + " \"" + fileInfo.FullName + "\" -o \"" + newFile + "\"";
                    commands.Add(commandForCompress);
                }
                catch (Exception exception)
                {
                }
            }
        }

        private String GetStats(FileInfo fileInfo)
        {
            string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(fileInfo.FullName);
            string fileName = Path.GetFileName(fileInfo.FullName);
            string basePath = Path.GetDirectoryName(fileInfo.FullName);
            String newPath = Path.Combine(basePath, fileNameWithoutExtension + ".webp");

            long oldLength = fileInfo.Length;
            FileInfo newFile = new FileInfo(newPath);
            long newLength = newFile.Length;

            if (cbDelete.Checked)
            {
                fileInfo.Delete();
            }
            else
            {
                if (oldLength > newLength)
                {
                    fileInfo.Delete();
                }
                else
                {
                    newFile.Delete();

                }
            }
            return fileName + "\n" + fileInfo.FullName + "\n" + (oldLength).ToString() + "\t" + newLength.ToString() + "";
        }

        private void GenerateStats(List<FileInfo> info)
        {
            List<String> stats = new List<string>();
            foreach (var fileInfo in info)
            {
                stats.Add(GetStats(fileInfo));
            }
            File.WriteAllText(Path.Combine(Path.GetDirectoryName(txtPath.Text.Trim()), "stats.log"), string.Join("\n\n", stats));
            MessageBox.Show("Successfully Converted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtConvert_Click(object sender, EventArgs e)
        {
            commands = new List<string>();
            handler = new CommandProcessHandler();
            PathType pathType = txtPath.Text.GetPathType();
            bool isValid = false;

            if (pathType != PathType.None)
            {
                String folderPath = Path.GetDirectoryName(txtPath.Text);

                List<FileInfo> info = null;
                if (rbFile.Checked && pathType == PathType.File)
                {
                    isValid = true;

                    info = new List<FileInfo>() { new FileInfo(txtPath.Text.Trim()) };

                    GenerateCommands(info);
                }
                else if (rbFolder.Checked && pathType == PathType.Directory)
                {
                    DirectoryInfo directoryInfo = new DirectoryInfo(txtPath.Text.Trim());
                    List<String> filters = new List<string>();
                    if (cbPNG.Checked)
                    {
                        filters.Add("*." + cbPNG.Text.ToLower());

                    }
                    if (cbJPG.Checked)
                    {
                        filters.Add("*." + cbJPG.Text.ToLower());

                    }

                    if (cbJPEG.Checked)
                    {
                        filters.Add("*." + cbJPEG.Text.ToLower());

                    }
                    if (cbTiff.Checked)
                    {
                        filters.Add("*." + cbTiff.Text.ToLower());

                    }

                    if (filters.Any())
                    {
                        isValid = true;
                        info = directoryInfo.GetFilesOnMultipleFilter(string.Join("|", filters), SearchOption.AllDirectories).ToList();
                        GenerateCommands(info);
                    }
                }
                if (isValid)
                {
                    handler.Process(commands, false);
                    if (info != null)
                    {
                        GenerateStats(info);
                    }
                }
            }
            if (!isValid)
            {
                MessageBox.Show("Please provide all inputs", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbQuality_Scroll(object sender, EventArgs e)
        {
            qualityToolTip.SetToolTip(tbQuality, tbQuality.Value.ToString());
        }

        private void llOpenOutput_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (txtPath.Text.GetPathType() != PathType.None)
            {
                ProcessStartInfo pfi = new ProcessStartInfo("Explorer.exe", Path.GetDirectoryName(txtPath.Text.Trim()));
                Process.Start(pfi);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.StartPosition = FormStartPosition.CenterScreen;
            about.ShowDialog();

        }

    }

}
