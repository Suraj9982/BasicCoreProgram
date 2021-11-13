using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    class SwapNumbers
    {
        public void Swapingnumbes()
        {
            int numberOne, numberTwo, temp;
            Console.WriteLine("enter first number");
            numberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the second number");
            numberTwo = Convert.ToInt32(Console.ReadLine());
            temp = numberOne;
            numberOne = numberTwo;
            numberTwo = temp;
            Console.WriteLine("after swapping the numbers numberOne={0}\nnumberTwo={1}", numberOne, numberTwo);
        }
    }
}
