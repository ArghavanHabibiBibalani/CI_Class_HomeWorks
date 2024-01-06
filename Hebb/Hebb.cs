namespace HebbianLearning
{
    public class Hebb
    {
        public int w1 = 0;
        public int w2 = 0;
        public int b = 0;
        public void HebbAlgo()
        {
            for (int i = 0; i < 4; i++)
            {
                //COMPUTING AND PLACEMENT IN NUMBERS CHART
                Program.numbersChart[4, i] = Program.numbersChart[0, i] * Program.numbersChart[3, i]; //COMPUTING AND PLACEMENT DELTA WEIGHT ONE
                Program.numbersChart[5, i] = Program.numbersChart[1, i] * Program.numbersChart[3, i]; //COMPUTING AND PLACEMENT DELTA WEIGHT TWO
                Program.numbersChart[6, i] = Program.numbersChart[3, i]; //COMPUTING AND PLACEMENT DELTA BIAS 

                Program.numbersChart[7, i] = w1 + Program.numbersChart[4, i]; //COMPUTING AND PLACEMENT WEIGHT ONE
                Program.numbersChart[8, i] = w2 + Program.numbersChart[5, i]; //COMPUTING AND PLACEMENT WEAGHT TWO
                Program.numbersChart[9, i] = b + Program.numbersChart[6, i]; //COMPUTING AND PLACEMENT BIAS

                w1 = Program.numbersChart[7, i];//UPDATING WEIGHT ONE IN EACH ROUND
                w2 = Program.numbersChart[8, i];//UPDATING WEIGHT TWO IN EACH ROUND
                b = Program.numbersChart[9, i];//UPDATING BIAS IN EACH ROUND

                string bSign = b <= 0 ? "+" : "-";//THIS IS JUST FOR RECOGNIZING WHICH SIGN IS APPROPRIATE FOR THE FORMULA, DON'T PAY ATTENTION PLZ!

                Console.WriteLine("This is the formula of Round" + (i+1));
                Console.WriteLine(w2 + " * " + "x_2 = " + -w1 + " * " + "x_1 " + bSign + " " + Math.Abs(b));
                if(i == 3) { Console.WriteLine("Congratulations!"); }
                Console.WriteLine();

            }

        }

    }
}