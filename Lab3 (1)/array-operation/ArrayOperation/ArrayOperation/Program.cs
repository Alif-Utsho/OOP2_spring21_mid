using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            int[] arr1 = new int[] { 1,2,3,4,5 };
            int[] arr1Copy = new int[arr1.Length];

            for(int i=0; i<arr1.Length; i++)
            {
                arr1Copy[i] = arr1[i];
            }

            for(int i=0; i<arr1Copy.Length; i++)
            {
                Console.Write(arr1Copy[i]+ " ");
            }
            Console.WriteLine();
            Console.WriteLine();


            //Task 2
            int[] arr2 = new int[] { 1, 6, 4, 11, 4, 6, 8, 4, 6, 10 };
            int duplicate = 0;
            int single = 0;

            for (int i=0; i<arr2.Length; i++)
            {
                for(int j=i+1; j<arr2.Length; j++)
                {
                    if (arr2[i] == arr2[j])
                    {
                        duplicate++;
                        break;
                    }
                    else
                    {
                        single++;
                        break;
                    }
                }
            }
            Console.WriteLine("Duplicate element {0}", duplicate);
            Console.WriteLine("Single element {0}", single);

            Console.ReadKey();
        }
    }
}
