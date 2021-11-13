using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    class LeapYear
    {
        public void FindleapYear()
        {
            Console.WriteLine("enter the year");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year % 400 == 0)
            {
                Console.WriteLine(year + " is a leap year");
            }
            else if (year % 100 == 0)
            {
                Console.WriteLine(year + " is not a leap year");
            }
            else if (year % 4 == 0)
            {
                Console.WriteLine(year + "is leap year");
            }
            else
            {
                Console.WriteLine(year + "the year is not leap year");
            }
        }
    }
}
