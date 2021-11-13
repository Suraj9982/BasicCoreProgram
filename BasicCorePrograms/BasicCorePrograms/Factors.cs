using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    class Factors
    {
        public void PrimeFactornumber()
        {
            Console.WriteLine("Enter the number for prime factors");
            int num = Convert.ToInt32(Console.ReadLine());
            int count=0, flag=0;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    count = 0;
                    for(int j = 1; j <= i; j++)
                    {
                        if (i % j == 0)
                            count++;
                    }
                    if (count == 2)
                    {
                        flag = 1;
                        Console.WriteLine(i + " ");
                    }
                }
            }
            if (flag == 0)
            {
                Console.WriteLine("there is no prime factors");
            }
        }    
    }
}
