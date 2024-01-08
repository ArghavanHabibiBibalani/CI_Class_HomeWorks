
using System;

namespace ANDPerceptron
{
    public class Perceptron
    {
        public double w1 = 0;
        public double w2 = 0;
        public double b = 0;
        public double alpha = 1;
        int count = 0;
        double deltaW1;
        double deltaW2;
        double deltaB;
        public void PerceptronAlgo()
        {
            int epoch = 1;
            while (epoch <= 10)
            {
                Console.WriteLine($"Epoch {epoch}:");

                for (int i = 0; i < 4; i++)
                {
                    double netInput = w1 * Program.numbersChart[0, i] + w2 * Program.numbersChart[1, i] + b;
                    int target = (int)Program.numbersChart[3, i];

                    int output = (netInput > 0.2) ? 1 : ((netInput < -0.2) ? -1 : 0);

                    if(output == target)
                    {
                        deltaW1 = 0;
                        deltaW2 = 0;
                        deltaB = 0;
                    }
                    else
                    {
                        deltaW1 = alpha * target * Program.numbersChart[0, i];
                        deltaW2 = alpha * target * Program.numbersChart[1, i];
                        deltaB = alpha * target;

                        w1 += deltaW1;
                        w2 += deltaW2;
                        b += deltaB;
                    }

                    Program.numbersChart[6, i] = deltaW1;
                    Program.numbersChart[7, i] = deltaW2;
                    Program.numbersChart[8, i] = deltaB;


                    Program.numbersChart[9, i] = w1;
                    Program.numbersChart[10, i] = w2;
                    Program.numbersChart[11, i] = b;

                    Console.WriteLine($"{Program.numbersChart[0, i]} {Program.numbersChart[1, i]} {Program.numbersChart[2, i]} {netInput} {output} {target} {deltaW1} {deltaW2} {deltaB} {w1} {w2} {b}");
                }

                if (CheckConvergence())
                {
                    Console.WriteLine("Converged. Stopping training.");
                    break;
                }

                epoch++;
            }
        }

        private bool CheckConvergence()
        {
            bool ans;
            for (int i = 0; i < 4; i++)
            {
                if (Program.numbersChart[6, i] != 0 || Program.numbersChart[7, i] != 0 || Program.numbersChart[8, i] != 0)
                {
                    ans = false;
                }
            }
            ans = true;
            return ans;
        }
    }
}
