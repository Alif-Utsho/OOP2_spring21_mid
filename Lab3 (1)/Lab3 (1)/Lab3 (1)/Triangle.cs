using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3__1_
{
    class Triangle
    {
        private int x, y, z;

        public Triangle(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public void showInfo()
        {
            Console.WriteLine("1st line: {0}", x);
            Console.WriteLine("2nd line: {0}", y);
            Console.WriteLine("3rd line: {0}", z);

            Console.WriteLine(TestTriangle());
        }

        private string TestTriangle()
        {
            if(x == y && y == z)
            {
                return "This is an equilateral triangle";
            }

            else if (x == y || x == z || y == z)
            {
                return "This is an isosceles triangle";
            }
            else
            {
                return "This is a scalene triangle";
            }
        }

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { x = value; }
        }

        public int Z
        {
            get { return z; }
            set { z = value; }
        }


    }
}
