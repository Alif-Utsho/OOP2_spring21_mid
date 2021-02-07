using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labtask4
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 20;
            int odd = 0, even = 0;

            for (int i = 0; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    even += i;
                }
                else
                {
                    odd += i;
                }
                
            }
            Console.WriteLine("Even sum: "+ even);
            Console.WriteLine("Odd sum: " + odd);

            Console.ReadKey();
        }
    }
}
