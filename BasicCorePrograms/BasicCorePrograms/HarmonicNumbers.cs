using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    class HarmonicNumbers
    {
        public void PrintHarmonicnumbers()
        {
            Console.WriteLine("enter the number to print the nth harmonic numbers");
            double num = Convert.ToDouble(Console.ReadLine());
            double sum = 0.0;
            for (double i = 1; i <= num; i++)
            {
                if (i <= num)
                {
                    Console.WriteLine("1/{0}+", +i);
                }
                sum += (1 / i);
            }
            Console.WriteLine("The value of harmonic numbers are " + sum);
        }
    }
}
