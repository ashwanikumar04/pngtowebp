using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PngToWebP
{
    public class CommandProcessHandler
    {
        [DllImport("kernel32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        [DllImport("kernel32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool FreeConsole();

        public Process CurrentProcess { get; private set; }
        private ProcessStartInfo CurrentProcessStartInfo { get; set; }
        public CommandProcessHandler()
        {
            CurrentProcess = new Process();
        }

        public void Process(List<String> commands, bool redirectStandardOutput = true)
        {
            if (commands.Count == 0)
            {
                return;
            }
            redirectStandardOutput = true;
            CurrentProcessStartInfo = new ProcessStartInfo();
            CurrentProcessStartInfo.RedirectStandardInput = true;
            CurrentProcessStartInfo.RedirectStandardOutput = redirectStandardOutput;
            CurrentProcessStartInfo.FileName = "cmd.exe ";
            CurrentProcessStartInfo.UseShellExecute = false;
            CurrentProcessStartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            CurrentProcess.StartInfo = CurrentProcessStartInfo;
            CurrentProcessStartInfo.CreateNoWindow = true;
            CurrentProcess.Start();
            Thread.Sleep(200);
            if (redirectStandardOutput)
            {
                CurrentProcess.BeginOutputReadLine();
            }
            using (StreamWriter sw = CurrentProcess.StandardInput)
            {
                if (sw.BaseStream.CanWrite)
                {
                    foreach (string command in commands)
                    {
                        sw.WriteLine(command);
                    }
                }
            }
            while (!CurrentProcess.HasExited)
            {
                Application.DoEvents(); // This keeps your form responsive by processing events
            }
        }
    }
}
