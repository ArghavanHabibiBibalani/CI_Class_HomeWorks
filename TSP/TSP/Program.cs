using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TSP
{
    class Program
    {
        static void Main()
        {
            List<City> cities = ReadCitiesFromFile("TSP51.txt");

            TSP tsp = new TSP(cities);
            tsp.Run();
        }

        static List<City> ReadCitiesFromFile(string filePath)
        {
            List<City> cities = new List<City>();

             string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    string[] parts = line.Split(' ');
                    if (parts.Length == 3 &&
                        int.TryParse(parts[0], out int number) &&
                        double.TryParse(parts[1], out double x) &&
                        double.TryParse(parts[2], out double y))
                    {
                        cities.Add(new City(number, x, y));
                    }
                    else
                    {
                        Console.WriteLine($"Invalid line: {line}");
                    }
                }
           
            return cities;
        }
    }
}
