using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                FailProcess();
            }
            catch { }

            Console.WriteLine("Failed to fail process!");
            Console.ReadKey();
        }

        static void FailProcess()
        {
            try
            {
                System.Diagnostics.Process[] processlist = System.Diagnostics.Process.GetProcesses();
                string processName = "Task1";
                foreach (System.Diagnostics.Process process in processlist)
                    if (process.ProcessName.Contains(processName)) process.Kill();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}