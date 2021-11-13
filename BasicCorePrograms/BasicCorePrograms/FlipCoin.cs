using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class FlipCoin
    {
        /// <summary>
        /// This flipthecoin method is a simulation of flip coin game.
        /// This method flip the coin till the user wants to flip. 
        /// This method also give the percentage of heads and tails
        /// </summary>
        public void Flipthecoin()
        {
            Console.WriteLine("enter the number of times to flip the coin");
            int num = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            double headcount = 0, tailcount = 0;
            for (int i = 0; i < num; i++)
            {
                double check = random.NextDouble();
                if (check < 0.5)
                {
                    Console.WriteLine("heads");
                    headcount++;
                }
                else
                {
                    Console.WriteLine("tails");
                    tailcount++;
                }
            }
            double headpercentage = (headcount / num) * 100;
            Console.WriteLine("Head percenatage is in % =" + headpercentage);
            double tailpercentage = (tailcount / num) * 100;
            Console.WriteLine("Tail percenatage is in % =" + tailpercentage);
        }
    }
}
