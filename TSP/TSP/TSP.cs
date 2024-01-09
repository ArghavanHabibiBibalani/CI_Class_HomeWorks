using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSP
{
    class TSP
    {
        private const int _populationSize = 100;
        private const int _generations = 500;

        private List<int> _bestTour { get; set; }
        private List<City> _cities { get; set; }
        public List<double> _fitnessValues = new List<double>();
        private double _bestTourDistance { get; set; }
        private Random _random = new Random();

        public TSP(List<City> cities)
        {
            _cities = cities;
            _bestTour = new List<int>();
            _bestTourDistance = 0;
        }

        public void Run()
        {
            List<List<int>> population = InitializePopulation();

            for (int generation = 0; generation < _generations; generation++)
            {
                List<double> fitnessValues = FitnessCalculator(population);

                int bestIndex = BestIndex(fitnessValues);
                List<int> currentBestTour = population[bestIndex];
                double currentBestDistance = TotalDistance(currentBestTour);

                if (currentBestDistance < _bestTourDistance || _bestTourDistance == 0)
                {
                    _bestTourDistance = currentBestDistance;
                    _bestTour = new List<int>(currentBestTour);
                    Console.WriteLine($"Generation {generation}, Best Distance: {_bestTourDistance}");
                }

                List<List<int>> newPopulation = CreateNewPopulation(population, fitnessValues);

                for (int i = 0; i < _populationSize; i++)
                {
                    newPopulation[i] = population[bestIndex];
                }

                population = newPopulation;
            }

            Console.WriteLine("Best Tour: " + string.Join(" -> ", _bestTour));
            Console.WriteLine("Best Tour Distance: " + _bestTourDistance);
        }

        private List<List<int>> InitializePopulation()
        {
            List<List<int>> population = new List<List<int>>();

            for (int i = 0; i < _populationSize; i++)
            {
                List<int> tour = Enumerable.Range(0, _cities.Count).OrderBy(x => _random.Next()).ToList();
                population.Add(tour);
            }

            return population;
        }

        private List<double> FitnessCalculator(List<List<int>> population)
        {
            List<double> fitnessValues = new List<double>();

            foreach (var tour in population)
            {
                double distance = TotalDistance(tour);
                fitnessValues.Add(1 / distance);

            }

            return fitnessValues;
        }

        private int BestIndex(List<double> fitnessValues)
        {
            return fitnessValues.IndexOf(fitnessValues.Max());
        }

        private List<List<int>> CreateNewPopulation(List<List<int>> oldPopulation, List<double> fitnessValues)
        {
            List<List<int>> newPopulation = new List<List<int>>();

            newPopulation.AddRange(oldPopulation);

            for (int i = 0; i < _populationSize; i += 2)
            {
                List<int> parent1 = SelectParent(oldPopulation, fitnessValues);
                List<int> parent2 = SelectParent(oldPopulation, fitnessValues);
                List<int> child1, child2;

                Crossover(parent1, parent2, out child1, out child2);

                Mutation(child1);
                Mutation(child2);

                newPopulation.Add(child1);
                newPopulation.Add(child2);
            }

            return newPopulation;
        }

        private List<int> SelectParent(List<List<int>> population, List<double> fitnessValues)
        {
            double totalFitness = fitnessValues.Sum();
            double randomNumber = _random.NextDouble() * totalFitness;

            double cumulativeFitness = 0;
            for (int i = 0; i < _populationSize; i++)
            {
                cumulativeFitness += fitnessValues[i];
                if (cumulativeFitness >= randomNumber)
                {
                    return population[i];
                }
            }

            return population[0];
        }


        private void Crossover(List<int> parent1, List<int> parent2, out List<int> child1, out List<int> child2)
        {
            int crossoverPoint1 = _random.Next(0, _cities.Count);
            int crossoverPoint2 = _random.Next(crossoverPoint1, _cities.Count);

            List<int> segment1 = parent1.Skip(crossoverPoint1).Take(crossoverPoint2 - crossoverPoint1).ToList();
            List<int> segment2 = parent2.Except(segment1).ToList();

            child1 = segment1.Concat(segment2).ToList();
            child2 = segment2.Concat(segment1).ToList();
        }

        private void Mutation(List<int> tour)
        {
            if (_random.NextDouble() < 0.1)
            {
                int index1 = _random.Next(0, tour.Count);
                int index2 = _random.Next(0, tour.Count);

                while (index1 == index2)
                {
                    index2 = _random.Next(0, tour.Count);
                }

                Reverse(tour, Math.Min(index1, index2), Math.Max(index1, index2));
            }
        }

        private void Reverse(List<int> list, int start, int end)
        {
            while (start < end)
            {
                int temp = list[start];
                list[start] = list[end];
                list[end] = temp;
                start++;
                end--;
            }
        }


        private double TotalDistance(List<int> tour)
        {
            double distance = 0;

            for (int i = 0; i < tour.Count - 1; i++)
            {
                distance += Distance(_cities[tour[i]], _cities[tour[i + 1]]);
            }

            if (tour.Count > 0)
            {
                distance += Distance(_cities[tour[tour.Count - 1]], _cities[tour[0]]);
            }

            return distance;
        }

        private double Distance(City city1, City city2)
        {
            return Math.Sqrt(Math.Pow(city2.X - city1.X, 2) + Math.Pow(city2.Y - city1.Y, 2));
        }
    }
}
