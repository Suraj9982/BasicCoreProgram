using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    class LargestNumber
    {
        public void Maximumnumber() 
        {
            int i = 0, large = 0;
            int[] numbers = new int[3];
            Console.WriteLine("enter the numbers");
            for (i = 0; i < numbers.Length; i++)
            {
                Console.Write("numbers{0}=", i);
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            large = numbers[0];
            for (i = 0; i < numbers.Length; i++)
            {
                if (large < numbers[i])
                {
                    large = numbers[i];
                }
            }
            Console.WriteLine("largest number is = {0}", large);
        }
    }
}
