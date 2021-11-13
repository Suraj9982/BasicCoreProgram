using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    class QuoteintAndRemainder
    {
        public void FindQuoteintRemainder()
        {
            Console.WriteLine("enter the dividend");
            int dividend = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the divisor");
            int divisor = Convert.ToInt32(Console.ReadLine());
            int quoteint = dividend / divisor;
            int remainder = dividend % divisor;
            Console.WriteLine("Quoteint is ={0}\nremainder is ={1}", quoteint, remainder);
        }
    }
}
