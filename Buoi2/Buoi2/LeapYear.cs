using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Buoi2
{
    internal class LeapYear
    {
        public void leapYear()
        {
            Console.WriteLine("Enter month:");
            string month = Console.ReadLine();
            Console.WriteLine("Enter year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            Boolean isLeapYear = false;
            if (year % 100 == 0)
            {
                isLeapYear = false;
            }
            else
            {
                if (year % 4 == 0)
                {
                    isLeapYear = true;
                }
            }
            if (isLeapYear == true)
            {
                Console.WriteLine("It is leap year."    );
            }
            else
            {
                Console.WriteLine("It is not leap year.");
            }
            month = month.ToLower();
            string[] day31 = { "january", "march", "may", "july", "august", "october", "december" };
            string[] day30 = { "april", "june", "september", "november" };
            if (day31.Contains(month))
            {
                Console.WriteLine(month + " has 31 days.");
            }
            else if (day30.Contains(month))
            {
                Console.WriteLine(month + " has 30 days.");
            }
            else
            {
                if (month.Equals("february"))
                {
                    if (isLeapYear == true)
                    {
                        Console.WriteLine(month + " has 29 days.");
                    }
                    else
                    {
                        Console.WriteLine(month + " has 28 days.");
                    }
                }
                }
            }

    }
}
