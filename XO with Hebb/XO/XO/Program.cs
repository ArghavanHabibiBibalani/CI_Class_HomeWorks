using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XO
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            //string valuesPath = @"C:\Users\Spino\Desktop\Hebb\Hebb\CI_Class\XO with Hebb\XO\XO\Values.txt";
            //List<string> values = File.ReadAllLines(valuesPath).ToList();

            List<Data> sapratedData = new List<Data>();
            int[] testingData = new int[25];

            //foreach (Data data in sapratedData)
            //{
            //    data.x1 = -1;
            //    data.x2 = -1;
            //    data.x3 = -1;
            //   data.x4 = -1;
            //    data.x5 = -1;
            //    data.x6 = -1;
            //    data.x7 = -1;
            //    data.x8 = -1;  
            //    data.x9 = -1;
            //    data.x10 = -1;
            //    data.x11 = -1;
            //    data.x12 = -1;
            //    data.x13 = -1;
            //    data.x14 = -1;
            //    data.x15 = -1;
            //    data.x16 = -1;
            //    data.x17 = -1;
            //    data.x18 = -1;
            //    data.x19 = -1;
            //    data.x20 = -1;
            //    data.x21 = -1; 
            //    data.x22 = -1;
            //    data.x23 = -1;
            //    data.x24 = -1;
            //    data.x25 = -1;

            //}
            //foreach (Data data in testingData)
            //{
            //    data.x1 = -1;
            //    data.x2 = -1;
            //    data.x3 = -1;
            //    data.x4 = -1;
            //    data.x5 = -1;
            //    data.x6 = -1;
            //    data.x7 = -1;
            //    data.x8 = -1;
            //    data.x9 = -1;
            //    data.x10 = -1;
            //    data.x11 = -1;
            //    data.x12 = -1;
            //    data.x13 = -1;
            //    data.x14 = -1;
            //    data.x15 = -1;
            //    data.x16 = -1;
            //    data.x17 = -1;
            //    data.x18 = -1;
            //    data.x19 = -1;
            //    data.x20 = -1;
            //    data.x21 = -1;
            //    data.x22 = -1;
            //    data.x23 = -1;
            //    data.x24 = -1;
            //    data.x25 = -1;

            //}


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(sapratedData, testingData));


        }
    }
}


