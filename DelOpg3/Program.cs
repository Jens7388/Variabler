using System;

namespace DelOpg3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv et bogstav:");
            char letter = Console.ReadKey().KeyChar;
            //Udskriver det indtastede bogstav på ny linje med det samme
            Console.WriteLine($"\nDu tastede: '{letter}'");
            Console.ReadLine();
        }
    }
}
