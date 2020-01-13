using System;

namespace Variabler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hvad er dit navn?");
            string yourName = Console.ReadLine();
            Console.WriteLine($"Hej {yourName}");
            Console.ReadLine();     
        }
    }
}
