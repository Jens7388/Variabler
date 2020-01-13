using System;

namespace DelOpg6
{
    class Program
    {
        static void Main(string[] args)
        {
            bool done = false;
            while(!done)
            {
                Console.Write("Indtast din vægt: ");
                string input = Console.ReadLine();
                //Tjek om input er et tal, hvis ikke, udskriv fejlbesked
                bool wasNumber = double.TryParse(input, out double weight);
                if(!wasNumber)
                {
                    Console.WriteLine("Der skete en fejl, tryk enter for at prøve igen.");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine($"Din vægt er {weight} kg");
                    done = true;
                    Console.ReadLine();
                }
            }

        }
    }
}
