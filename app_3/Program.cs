using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app_3
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 2)
            {
                Console.WriteLine("Erorr!");
                Console.ReadKey();
                return;
            }
            int sum = 0;
            int x;
            if (args.Contains("+"))
            {
                foreach (var el in args)
                {
                    sum += int.TryParse(el, out x) ? x : 1;
                }
                Console.WriteLine("Результат суммирования: " + sum);
            }
            else Console.WriteLine("Неверная операция");
            Console.ReadKey();
        }
    }
}