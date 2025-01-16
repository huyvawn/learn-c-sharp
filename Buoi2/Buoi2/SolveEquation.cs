using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2
{
    internal class SolveEquation
    {
        public void solveEquation()
        {
            Console.WriteLine("Solving ax + b = 0");
            Console.WriteLine("Enter a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter b:");
            int b = int.Parse(Console.ReadLine());
            double x = -b / a;
            Console.WriteLine("x = " + x);
        }
    }
}
