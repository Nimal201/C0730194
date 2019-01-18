using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0730194
{
    class Program
    {
        static void Main(string[] args)
        {

            int sum = 0;
            int i = 1;
            for (int i = 1000; i > +117; i -= 82)
            {
                sum += 1;
            }

            Console.WriteLine("The sum of the number is: {0}", sum);
            Console.ReadLine();
        }

       
    }
}
