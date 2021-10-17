using System;

namespace Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            string string1 = "Вячеслав";
            {
                Console.WriteLine("Введите имя");
            }
                string string2 = Console.ReadLine();
                if (string2 == string1)
                {
                    Console.WriteLine("Привет, Вячеслав");
                }
                else 
                {
                    Console.WriteLine("Нет такого имени");
                }
        }    
    }
}