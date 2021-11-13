using System;

namespace BasicCorePrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("CHOOSE ONE OPTION TO RUN THE PROGRAM\n1.FlipCoin\n2.LeapYear\n3.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        FlipCoin flip = new FlipCoin();
                        flip.Flipthecoin();
                        break;
                    case 2:
                        LeapYear leap = new LeapYear();
                        leap.FindleapYear();
                        break;
                    case 3:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("your choice should be between 1 to 3");
                        break;
                }
            }
        }
    }
}
