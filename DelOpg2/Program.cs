using System;

namespace DelOpg2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool done = false;
            while(!done)
            {
                Console.WriteLine("Hvad er dit navn?");
                string yourName = Console.ReadLine();
                Console.WriteLine("Hvad er din alder?");
                string ageInput = Console.ReadLine();
                //Tjek om ageInput er et tal, hvis ikke, udskriv fejlbesked
                bool wasNumber = Int32.TryParse(ageInput, out int yourAge);
                if(!wasNumber)
                {
                    Console.WriteLine("Der skete en fejl, tryk enter for at prøve igen.");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Hvor bor du?");
                    string yourLocation = Console.ReadLine();
                    Console.WriteLine($"Du hedder {yourName}, er {yourAge} år gammel, og bor i/på {yourLocation}.");
                    done = true;
                    Console.ReadLine();
                }
            }
        }
    }
}
