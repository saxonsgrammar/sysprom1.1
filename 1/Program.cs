using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            do
            {
                Console.Write("Введите номер задания: ");
                num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        Process process = new Process();
                        process.StartInfo = new ProcessStartInfo("notepad.exe");
                        // изначально пробовал запускать калькулятор, но WaitForExit() почему-то его не ловила и код окончания отображался без закрытия процесса
                        process.Start();
                        Console.WriteLine("Имя процесса: " + process.ProcessName);
                        Console.WriteLine("Процесс ждёт закрытия...");
                        process.WaitForExit();
                        Console.WriteLine("Процесс завершён с кодом " + process.ExitCode + "\n");
                        break;

                    case 2:
                        Process process2 = new Process();
                        process2.StartInfo = new ProcessStartInfo("notepad.exe");
                        process2.Start();
                        Console.WriteLine("Имя процесса: " + process2.ProcessName);
                        Console.Write("Ждать окончания/завершить процесс (1, 0)? ");
                        int num2 = Convert.ToInt32(Console.ReadLine());
                        if (num2 == 1)
                        {
                            Console.WriteLine("Процесс ждёт закрытия...");
                            process2.WaitForExit();
                        }
                        else if (num == 0)
                        {
                            Console.WriteLine("Процесс завершён");
                            process2.Kill();
                        }
                        Console.WriteLine("Процесс завершён с кодом " + process2.ExitCode + "\n");
                        break;

                    case 3:
                        Process process3 = new Process();
                        process3.StartInfo = new ProcessStartInfo(@"C:\Users\Mcintosh\Downloads\СисПром\сп1\app_3\bin\Debug\app_3.exe");
                        process3.StartInfo.Arguments = "7 3 +";
                        process3.Start();
                        process3.WaitForExit();
                        Console.WriteLine("Процесс завершился с кодом " + process3.ExitCode + "\n");
                        break;

                    case 4:
                        Process process4 = new Process();
                        process4.StartInfo = new ProcessStartInfo(@"C:\Users\Mcintosh\Downloads\СисПром\сп1\app_4\bin\Debug\app_4.exe");
                        process4.StartInfo.Arguments = @"C:\Users\Mcintosh\Downloads\СисПром\сп1\1\test.txt bicycle";
                        process4.Start();
                        process4.WaitForExit();
                        Console.WriteLine("Процесс завершился с кодом " + process4.ExitCode + "\n");
                        break;
                }
            } while (num != 0);
            Console.WriteLine();
        }
    }
}