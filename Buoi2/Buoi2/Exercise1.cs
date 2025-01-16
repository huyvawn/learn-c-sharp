using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2
{
    internal class Exercise1
    {
        public void ex1() {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter year of birth: ");
            int birthYear = int.Parse(Console.ReadLine());
            Console.WriteLine($"Hi, {name}" + $". Your were born in {birthYear}");
        }
    }
}
