using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2
{
    internal class CheckEvenNumbers
    {
        public void CheckEvenNumber()
        {
            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("It is an even number."   );
            }
            else
            {
                Console.WriteLine("It is not an even number.");
            }
        }
    }
}
