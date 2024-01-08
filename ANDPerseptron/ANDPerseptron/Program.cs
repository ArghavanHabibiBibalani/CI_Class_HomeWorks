using System;

namespace ANDPerceptron
{
    internal static class Program
    {
        public static double[,] numbersChart = new double[12, 4];

        static void Main()
        {
            Console.WriteLine("Please enter your inputs: [x1, x2, bias, y]");

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    numbersChart[j, i] = Convert.ToDouble(Console.ReadLine());
                }

            }

            Console.WriteLine("Just a moment...");

            Perceptron perceptron = new Perceptron();
            perceptron.PerceptronAlgo();
        }
    }
}

