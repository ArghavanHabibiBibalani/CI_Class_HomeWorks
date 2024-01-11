using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightQueen
{
    class EightQueensGeneticSolver
    {
        private const int _PopulationSize = 100;
        private const int _generations = 500;
        private List<int[]> _population { get; set; }
        private Random _random { get; set; }

        public EightQueensGeneticSolver()
        {
            _population = new List<int[]>();
            _random = new Random();
        }

        public void SolveEightQueens()
        {
            InitializePopulation();

            for (int generation = 0; generation < _generations; generation++)
            {
                EvaluatePopulation();

                if (HasSolution())
                {
                    Console.WriteLine($"Solution found in generation {generation}");
                    PrintBoard(GetBestSolution());
                    return;
                }

                List<int[]> newPopulation = CreateNewPopulation();
                _population = newPopulation;
            }

            Console.WriteLine("No solution found.");
        }

        private void InitializePopulation()
        {
            for (int i = 0; i < _PopulationSize; i++)
            {
                int[] chromosome = Enumerable.Range(0, 8).OrderBy(x => _random.Next()).Concat(new int[] { 0 }).ToArray();
                _population.Add(chromosome);
            }
        }

        private void EvaluatePopulation()
        {
            foreach (var chromosome in _population)
            {
                int conflicts = CountConflicts(chromosome);
                chromosome[8] = -conflicts; 
            }
        }

        private List<int[]> CreateNewPopulation()
        {
            List<int[]> newPopulation = new List<int[]>();

            for (int i = 0; i < _PopulationSize; i += 2)
            {
                int[] parent1 = SelectParent();
                int[] parent2 = SelectParent();

                int[] child1, child2;
                Crossover(parent1, parent2, out child1, out child2);

                Mutate(child1);
                Mutate(child2);

                newPopulation.Add(child1);
                newPopulation.Add(child2);
            }

            return newPopulation;
        }

        private int[] SelectParent()
        {
            double totalFitness = _population.Sum(chromosome => Math.Pow(2, chromosome[8]));
            double cumulativeFitness = 0;

            foreach (var chromosome in _population)
            {
                cumulativeFitness += Math.Pow(2, chromosome[8]);
            }

            double randomNumber = _random.NextDouble() * totalFitness;
            double currentSum = 0;

            foreach (var chromosome in _population)
            {
                currentSum += Math.Pow(2, chromosome[8]);
                if (currentSum >= randomNumber)
                {
                    return chromosome;
                }
            }

            return _population.First().ToArray();
        }

        private void Crossover(int[] parent1, int[] parent2, out int[] child1, out int[] child2)
        {
            
            int crossoverPoint = _random.Next(0, 8);

             child1 = parent1.Take(crossoverPoint).Concat(parent2.Skip(crossoverPoint)).ToArray();
             child2 = parent2.Take(crossoverPoint).Concat(parent1.Skip(crossoverPoint)).ToArray();
           
        }

        private void Mutate(int[] chromosome)
        {
            
            int mutationPoint = _random.Next(0, 8);
            int newValue = _random.Next(0, 8);

             chromosome[mutationPoint] = newValue;
            
        }

        private int CountConflicts(int[] chromosome)
        {
            int conflicts = 0;

            for (int i = 0; i < 8; i++)
            {
                for (int j = i + 1; j < 8; j++)
                {
                    if (chromosome[i] == chromosome[j] || Math.Abs(i - j) == Math.Abs(chromosome[i] - chromosome[j]))
                    {
                        conflicts++;
                    }
                }
            }

            return conflicts;
        }

        private bool HasSolution()
        {
            return _population.Any(chromosome => chromosome.Length > 8 && chromosome[8] == 0);
        }

        private int[] GetBestSolution()
        {
            return _population.OrderByDescending(chromosome => chromosome[8]).First();
        }

        private void PrintBoard(int[] solution)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(solution[i] == j ? "Q " : "- ");
                }
                Console.WriteLine();
            }
        }


    }
}