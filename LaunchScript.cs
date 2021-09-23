using System;
using System.Diagnostics;
using System.IO;

namespace script_runner
{
    class LaunchScript
    {
        public static void Ps()
        {
            if (File.Exists(@"C:\script-runner\test-service.ps1"))
            {
                var ps1File = @"C:\script-runner\test-service.ps1";
                var startInfo = new ProcessStartInfo(ps1File)
                {
                    FileName = "powershell.exe",
                    Arguments = $"-NoProfile -ExecutionPolicy unrestricted \"{ps1File}\"",
                    UseShellExecute = false
                };
                Process.Start(startInfo);
                //Console.WriteLine("Script launched.");
                Logging.WriteEventLogEntry("Successfully ran script");
            }
            else
            {
                Console.WriteLine("Script not found.");
            }
        }
    }
}