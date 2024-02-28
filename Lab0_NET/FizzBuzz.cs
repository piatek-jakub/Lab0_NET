using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab0_NET
{
    internal class FizzBuzz
    {
        private int upperBound;

        public FizzBuzz(int uB)
        {
            upperBound = uB;
        }

        public void Display()
        {
            for(int i = 1; i < upperBound; i++)
            {
                string fizzbuzz = "";

                if (i % 3 == 0)
                {
                    fizzbuzz += "Fizz";
                }
                if (i % 5 == 0)
                {
                    fizzbuzz += "Buzz";
                }

                if(fizzbuzz == "")
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(fizzbuzz);
                }
            }
        }
    }
}
