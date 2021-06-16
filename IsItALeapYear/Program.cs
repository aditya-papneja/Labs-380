using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsItALeapYear
{
    public class Program
    {
        static void Main(string[] args)
        {
           //Console.WriteLine("Year 2000 is Leap year ? " + IsItALeapYear(2000));
        }

        public bool IsItALeapYear(int year)
        {
            bool isLeapYear = false;

            if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
            {
                isLeapYear = true;
            }
            return isLeapYear;
        }
    }
}
