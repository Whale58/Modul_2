﻿using System;

namespace Modul_2.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            const String MyName = "Виталий";
            byte MyAge = 27;
            bool HaveIApet = true;
            double MyShoeSize = 37.5;

            Console.WriteLine("My name is " + MyName);
            Console.WriteLine("MyAge " + MyAge);
            Console.WriteLine("Do I have a pet? " + HaveIApet);
            Console.WriteLine("My shoe size is " + MyShoeSize);
            
            Console.ReadKey();
        }
    }
}
