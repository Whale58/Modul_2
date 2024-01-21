using System;

namespace Modul_2.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            const String MyName = "Виталий";

            Console.WriteLine(MyName);

            Console.WriteLine("Привет Мир!");
            Console.WriteLine("Мне 25");
            Console.WriteLine("\t My name is \n {0}", MyName);
            Console.WriteLine("\u0023"); 

            Console.ReadKey();
        }
    }
}
