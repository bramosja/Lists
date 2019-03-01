using System;
using System.Collections.Generic;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>(){"Mercury", "Mars"};

            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            planetList.ForEach(planet => Console.WriteLine(planet));
            Console.WriteLine();

            List<string> lastPlanets = new List<string>(){"Neptune", "Uranus"};

            planetList.AddRange(lastPlanets);
            planetList.ForEach(planet => Console.WriteLine(planet));
            Console.WriteLine();

            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");
            planetList.ForEach(planet => Console.WriteLine(planet));
            Console.WriteLine();

            planetList.Add("Pluto");
            planetList.ForEach(planet => Console.WriteLine(planet));
            Console.WriteLine();

            List<string> rockyPlanets = planetList.GetRange(0, 4);
            rockyPlanets.ForEach(planet => Console.WriteLine(planet));
            Console.WriteLine();

            planetList.Remove("Pluto");
            planetList.ForEach(planet => Console.WriteLine(planet));
            Console.WriteLine();


            Random random = new Random();
            List<int> numbers = new List<int> {
                random.Next(10),
                random.Next(10),
                random.Next(10),
                random.Next(10),
                random.Next(10),
            };

            for(int i = 0; i < numbers.Count-1; i++){
                if(numbers.Contains(i)){
                    Console.WriteLine($"Contains {i}");
                } else {
                    Console.WriteLine($"Does not contain {i}");
                }
            }

        }
    }
}
