using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                // Multiple of 3 & 5
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                // Multiple of 3
                else if (i % 3 == 0 && i % 5 != 0)

                {
                    Console.WriteLine("Fizz");
                }
                // Multiple of 5
                else if (i % 3 != 0 && i % 5 == 0)
                {

                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();      
        }
    }
}
    
