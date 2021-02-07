using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_basic
{
    internal class Student
    {
        string name;
        int roll;

        public Student(string name, int roll)
        {
            this.name = name;
            this.roll = roll;
        }

        public void showAll()
        {
            Console.WriteLine("\tName: " + name);
            Console.WriteLine("\tRoll: " + roll);

        }
    }
}
