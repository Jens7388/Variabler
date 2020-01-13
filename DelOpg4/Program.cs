using System;

namespace DelOpg4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool done = false;
            while(!done)
            {
                Console.WriteLine("Indtast din alder:");
                string input = Console.ReadLine();
                //Tjek om input er et tal, hvis ikke, udskriv fejlbesked
                bool wasNumber = Int32.TryParse(input, out int yourAge);
                if(!wasNumber)
                {
                    Console.WriteLine("Der skete en fejl, tryk enter for at prøve igen.");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine($"Utroligt! Er du kun {yourAge} år gammel?");
                    done = true;
                    Console.ReadLine();
                }
            }
        }
    }
}
