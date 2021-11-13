using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    class PowerOfTwo
    {
        public void Findpoweroftwo()
        {
            Console.WriteLine("enter the number");
            double n = Convert.ToInt32(Console.ReadLine());
            double power = Math.Pow(2, n);
            Console.WriteLine("The value of 2^{0} is = " + power, n);
        }
    }
}
