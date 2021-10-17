using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Array1 = new int [5];
            var random = new Random();
            Console.WriteLine("Массив: ");
            for (int i = 0; i < Array1.Length; i++)
            Console.WriteLine((Array1[i] = random.Next(0,50)));
            Console.WriteLine("Итог: ");
            int[] Result = Array1.Where( i => i % 3 == 0).ToArray();
            Console.WriteLine(string.Join(",", Result));

            Console.ReadLine();
        }
    }
}
