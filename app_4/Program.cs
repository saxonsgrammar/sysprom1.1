using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app_4
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 2)
            {
                Console.WriteLine("Error!");
                Console.ReadKey();
                return;
            }
            string[] words;
            string file;
            using (StreamReader sr = new StreamReader(@"..\..\..\..\..\сп1\1\test.txt"))
            {
                file = sr.ReadToEnd();
            }
            char[] space = { ' ' };
            words = file.Split(space);
            int count = 0;
            foreach (string word in words)
            {
                if (word == args[1]) count++;
            }
            Console.Write("Кол-во слов: " + count);
            Console.ReadKey();
        }
    }
}