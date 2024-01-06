namespace HebbianLearning
{
    internal static class Program
    {

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        //[STAThread]
        public static int[,] numbersChart = new int[10, 4];
        static void Main()
        {
            //// To customize application configuration such as set high DPI settings or default font,
            //// see https://aka.ms/applicationconfiguration.
            //ApplicationConfiguration.Initialize();
            //Application.Run(new Form1());
            Console.WriteLine("Please inter your inputs: [x1, x2, b, y]");
            //FILLING ARRAY
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    numbersChart[j, i] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Hebb hebb = new Hebb();
            hebb.HebbAlgo();
        }

        


    }
    

}
