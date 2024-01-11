using System;
using System.Collections.Generic;
using System.Linq;

namespace EightQueen
{
    class Program
    {
        static void Main(string[] args)
        {
            EightQueensGeneticSolver solver = new EightQueensGeneticSolver();
            solver.SolveEightQueens();
        }
    }
    
}
