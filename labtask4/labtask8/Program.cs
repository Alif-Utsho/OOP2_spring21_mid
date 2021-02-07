using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labtask8
{
    class Program
    {
        static void Main(string[] args)
        {
            int physics = 82;
            int chemistry = 65;
            int biology = 88;
            int math = 93;
            int computer = 95;

            double sum = (physics + chemistry + biology + math + computer);

            double percentage = (sum / 500) * 100;

            Console.WriteLine("Percentage: "+percentage);

            if(percentage<100 && percentage >= 90)
            {
                Console.WriteLine("Grade: A+");
            }
            else if(percentage<90 && percentage >= 85)
            {
                Console.WriteLine("Grade: A");
            }
            else if (percentage < 85 && percentage >= 80)
            {
                Console.WriteLine("Grade: B+");
            }
            else if (percentage < 80 && percentage >= 75)
            {
                Console.WriteLine("Grade: B");
            }
            else if (percentage < 75 && percentage >= 50)
            {
                Console.WriteLine("Grade: C+");
            }
            else if (percentage < 50 && percentage >= 00)
            {
                Console.WriteLine("Grade: F");
            }
            else
            {
                Console.WriteLine("Invalid Number");
            }


            Console.ReadKey();
        }
    }
}
