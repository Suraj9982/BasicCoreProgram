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
                Console.WriteLine("CHOOSE ONE OPTION TO RUN THE PROGRAM\n1.FlipCoin\n2.LeapYear\n3.PowerOfTwo\n4.HarmonicNumbers\n5.Factors\n6.QuoteintREmainder\n7.SwapNumbers\n8.Exit");
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
                        PowerOfTwo power = new PowerOfTwo();
                        power.Findpoweroftwo();
                        break;
                    case 4:
                        HarmonicNumbers harmonic = new HarmonicNumbers();
                        harmonic.PrintHarmonicnumbers();
                        break;
                    case 5:
                        Factors fact = new Factors();
                        fact.PrimeFactornumber();
                        break;
                    case 6:
                        QuoteintAndRemainder number = new QuoteintAndRemainder();
                        number.FindQuoteintRemainder();
                        break;
                    case 7:
                        SwapNumbers swap = new SwapNumbers();
                        swap.Swapingnumbes();
                        break;
                    case 8:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("your choice should be between 1 to 8");
                        break;
                }
            }
        }
    }
}
