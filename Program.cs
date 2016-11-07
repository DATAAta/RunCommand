using System;
using System.Diagnostics;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(RunCommand());
        }

        public static bool RunCommand()
        {
            try
            {
                var procStartInfo = new ProcessStartInfo("cal")
                {
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = false
                };

                var proc = new Process { StartInfo = procStartInfo };
                proc.Start();

                // Get the output into a string
                var output = proc.StandardOutput.ReadToEnd();

                return proc.ExitCode == decimal.Zero ? true : false;
            }
            finally
            {
                // do something
            }
        }
    }
}
