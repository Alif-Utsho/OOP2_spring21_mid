using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 20;
            int odd = 0, even = 0;

            for (int i = 0; i <= number; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write("Even: "+i);
                    even = i;
                }
                else
                {
                    Console.Write("Odd: " + i);
                    odd = i;
                }
                Console.WriteLine(even + odd);
            }

            Console.ReadKey();
        }
    }
}
