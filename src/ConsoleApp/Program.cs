using ClassesLibrary;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Podaj wartosc:");
            int value = Convert.ToInt32(Console.ReadLine());
            Class1 obj = new Class1(value);

           

        }

       
        
    }
}
