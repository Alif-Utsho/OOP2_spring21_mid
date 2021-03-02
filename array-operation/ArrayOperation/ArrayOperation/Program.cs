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
            int[] arr1 = new int[] { 1, 2, 3, 4, 5 };
            int[] arr1Copy = new int[arr1.Length];

            for (int i = 0; i < arr1.Length; i++)
            {
                arr1Copy[i] = arr1[i];
            }

            for (int i = 0; i < arr1Copy.Length; i++)
            {
                Console.Write(arr1Copy[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();


            //Task 2
            int[] arr2 = new int[] { 1, 2, 3, 2, 1, 5, 3 };
            int duplicate = 0;

            for (int i = 0; i < arr2.Length; i++)
            {
                for (int j = i + 1; j < arr2.Length; j++)
                {
                    if (arr2[i] == arr2[j])
                    {
                        duplicate++;
                    }
                }
            }
            Console.WriteLine("Duplicate element {0}", duplicate);
            Console.WriteLine();

            //Task 3
            int[] arr3 = new int[] { 1, 2, 3, 2, 1, 5, 3 };
            int single = 0;

            for (int i = 0; i < arr3.Length; i++)
            {
                for (int j = i + 1; j < arr3.Length; j++)
                {
                    if (arr3[i] != arr3[j])
                    {
                        single++;
                    }
                }
            }
            Console.WriteLine("Single element {0}", single);

            Console.ReadKey();
        }
    }
}
