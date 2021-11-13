using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    class EvenOdd
    {
        public void Checkevenodd()
        {
            Console.WriteLine("enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num == 0)
            {
                Console.WriteLine("number should be greater tha Zero");
            }
            if (num % 2 == 0)
            {
                Console.WriteLine("number is even");
            }
            else
                Console.WriteLine("number is odd");
        }
    }
}
