using System;

namespace DelOpg5
{
    class Program
    {
        static void Main(string[] args)
        {
            bool done = false;
            while(!done)
            {
                Console.WriteLine("Hvad er temperaturen lige nu?");
                string input = Console.ReadLine();
                //Tjek om input er et tal, hvis ikke, udskriv fejlbesked
                bool wasNumber = double.TryParse(input, out double temperature);
                if(!wasNumber)
                {
                    Console.WriteLine("Der skete en fejl, tryk enter for at prøve igen.");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Hvad er din lokation?");
                    string yourLocation = Console.ReadLine();
                    Console.WriteLine($"{temperature} grader er da en fin temperatur for {yourLocation}");
                    done = true;
                    Console.ReadLine();
                }
            }
        }
    }
}
