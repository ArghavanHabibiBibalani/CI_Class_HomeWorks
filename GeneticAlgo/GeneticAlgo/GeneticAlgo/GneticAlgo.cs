using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgo
{
    internal class GneticAlgo
    {
        static int _populationSize = 20;
        int[] _chromosomeValues = new int[_populationSize];
        int[] _newChromosomeValue = new int[_populationSize];
        int[] _fitness = new int[_populationSize];
        int[] _choosenForm = new int[_populationSize];
        int[,] _population = new int[_populationSize, 8];
        int[,] _newPopulation = new int[_populationSize, 8];

        public GneticAlgo()
        {
            RandomNumberGenerator();
            BinaryForm(_chromosomeValues);

        }

        public int FitnessFunction(int number)
        {
            int result;
            result = (int)Math.Pow(number, 2);
            return result;
        }

        public int RandomNumberGenerator()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 255);
            int result = Math.Abs(randomNumber);

            return result;
        }

        public void PopulationMaker()
        {
            for(int i  = 0; i < _populationSize; i++)
            {
                int value = RandomNumberGenerator();
                _chromosomeValues[i] = value;

            }
        }

        public void BinaryForm(int[] chromosomeValues)
        {
            for (int i = 0; i < _populationSize; i++)
            {
                string toBinary = Convert.ToString(chromosomeValues[i], 2).PadLeft(8, '0');
                //Console.WriteLine(chromosomeValues[i]);
                //Console.WriteLine(toBinary);

                for (int j = 0; j < 8; j++)
                {
                    _population[i, j] = int.Parse(toBinary[j].ToString());
                    //Console.WriteLine(_population[i, j]);
                }
            }
        }


        public void DecimalForm(int[,] newPopulation)
        {
            string str = "";

            for (int i = 0; i < _populationSize; i++)
            {
                str = string.Join("", GetRow(newPopulation, i));

                // Convert characters to integers before converting to decimal
                int[] binaryArray = str.Select(c => int.Parse(c.ToString())).ToArray();

                _newChromosomeValue[i] = Convert.ToInt32(string.Join("", binaryArray), 2);
                //Console.WriteLine(_newChromosomeValue[i]);
            }
        }

        static int[] GetRow(int[,] matrix, int rowIndex)
        {
            int rowLength = matrix.GetLength(1);
            int[] row = new int[rowLength];

            for (int j = 0; j < rowLength; j++)
            {
                row[j] = matrix[rowIndex, j];
            }

            return row;
        }

        public void Fitness(int[] chromosomeValues)
        {
            for( int i = 0;i < chromosomeValues.Length; i++)
            {
                _fitness[i] = FitnessFunction(chromosomeValues[i]);
            }
        }

        public int Sum(int[] chromosomeValues)
        {
            int sum = 0;
            for( int i = 0; i< chromosomeValues.Length; i++)
            {
                sum += chromosomeValues[i];
            }
            return sum;
        }

        public int Avrage(int[] chromosomeValues)
        {
            int sum = Sum(chromosomeValues);
            int avrage = sum / chromosomeValues.Length;
            return avrage;
        }

        public void RouletteWheel(int[] _fitness, int[,] population)
        {

            int sum = Sum(_fitness);
            int average = Avrage(_fitness);
            //Console.WriteLine(sum);
            //Console.WriteLine(average);
            for (int i = 0; i < _fitness.Length; i++)
            {
                _choosenForm[i] = (int)Math.Round((double)_fitness[i] / average);
            }
            Random random = new Random();

            int pointer = 0;

            for (int i = 0; i < 20; i++)
            {
                double randomNumber = Math.Abs(random.Next(0, sum/average));
                for (int j = 0; j < _populationSize; j++)
                {
                    if (randomNumber >= pointer && randomNumber < _choosenForm[j] + pointer)
                    {
                        for (int k = 0; k < 8; k++)
                        {
                            _newPopulation[i, k] = population[j, k];
                            //Console.WriteLine(population[j, k]);
                            //Console.WriteLine(_newPopulation[i, k]);
                        }
                    }
                    pointer += _choosenForm[j];

                }
            }
        }

        public void CrossOver(int[,] newPopulation)
        {
            Random random = new Random();

            for(int i = 0;i < _populationSize/2; i += 2)
            {
                int[] x = new int[8];
                int[] y = new int[8];
                int randomNumber = Math.Abs(random.Next(0, 7));
                for(int j = 0; j < 8; j++)
                {
                    if(j < randomNumber)
                    {
                        x[j] = _newPopulation[i, j];
                        y[j] = _newPopulation[i + 1, 7 - j];
                    }
                    else
                    {
                        y[j] = _newPopulation[i, j];
                        x[j] = _newPopulation[i + 1, 7 - j];
                    }

                    _newPopulation[i, j] = x[j];
                    //Console.WriteLine(newPopulation[i, j]);
                    _newPopulation[i + 1, j] = y[j];
                    //Console.WriteLine(newPopulation[i + 1, j]);
                }
            }
        }

        public void Mutation(int[,] newPopulation)
        {
            Random random = new Random();
            for(int i = 0; i < _populationSize; i++ )
            {
                int randomNumber = Math.Abs(random.Next(0, 7));
                //Console.WriteLine(_newPopulation[i, randomNumber]);
                //Console.WriteLine(randomNumber);
                if (_newPopulation[i, randomNumber] == 0)
                {
                    _newPopulation[i, randomNumber] = 1;
                }
                else if(_newPopulation[i, randomNumber] == 1)
                {
                    _newPopulation[i, randomNumber] = 0;
                }
                //Console.WriteLine(_newPopulation[i, randomNumber]);
            }
        }

        public void Run()
        {
            PopulationMaker();
            BinaryForm(_chromosomeValues);

            int max = 0;
            for(int i = 0; i< _populationSize/ 2; i += 2)
            {

                if (Math.Max(_chromosomeValues[i] , _chromosomeValues[i+1]) > max)
                {
                    max = Math.Max(_chromosomeValues[i], _chromosomeValues[i + 1]);
                }
            }

            Console.WriteLine("YOUR MAX VALUE IS: " + max);

            Fitness(_chromosomeValues);
            RouletteWheel(_fitness, _population);
            CrossOver(_newPopulation);
            Mutation(_newPopulation);
            DecimalForm(_newPopulation);

            int max2 = 0;
            //for (int i = 0; i < _populationSize / 2; i += 2)
            //{
            //    if (Math.Max(_newChromosomeValue[i], _newChromosomeValue[i + 1]) > max2)
            //    {
            //        max2 = Math.Max(_newChromosomeValue[i], _newChromosomeValue[i + 1]);
                    
            //    }
            //}
            for(int i = 0; i< _populationSize; i++)
            {
                max2 = Math.Max(_newChromosomeValue[i], max2);
            }
            Console.WriteLine("YOUR NEW MAX VALUE IS: " + max2);



        }











    }
}
