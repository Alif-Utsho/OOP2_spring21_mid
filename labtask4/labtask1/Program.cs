﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labtask1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 20;

            for(int i=0; i<=20; i++)
            {
                if(i%2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();
        }
    }
}
