using System;
using System.Diagnostics;
using System.Linq;

namespace Toy.UniqueClient.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var currentProcess = Process.GetCurrentProcess();
                var myProgramName = currentProcess.ProcessName;

                var processes = Process.GetProcesses();
                var count = processes.Count(process => process.ProcessName == myProgramName);
                var message = $"{myProgramName} is {count} count";

                if (count > 1) 
                {
                    currentProcess.Kill();
                }

                Console.WriteLine(message);
                Console.ReadLine();
            }
        }
    }
}
