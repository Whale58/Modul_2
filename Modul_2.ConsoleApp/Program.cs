using System;

namespace Modul_2.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            byte age = checked((byte)int.Parse(Console.ReadLine()));
            Console.WriteLine("Ваш любимый день недели?");
            DayOfWeek day = (DayOfWeek)int.Parse(Console.ReadLine());
            Console.WriteLine("Your name is {0} and age is {1} ", name, age);
            Console.WriteLine("Ваш любимый день недели {0}", day);
            Console.ReadKey();
        }

    }
}