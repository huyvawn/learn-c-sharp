using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2
{
    internal class Bai1
    {
        public void indayso() {
            Console.WriteLine("Day so la: ");
            for (int i = 0; i < 11; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + " ");
                }
            }
        }
    }
}
