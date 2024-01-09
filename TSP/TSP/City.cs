using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSP
{
    class City
    {
        public int Number { get; set; }
        public double X { get; set; }
        public double Y { get; set; }

        public City(int number, double x, double y)
        {
            Number = number;
            X = x;
            Y = y;
        }
    }

}
