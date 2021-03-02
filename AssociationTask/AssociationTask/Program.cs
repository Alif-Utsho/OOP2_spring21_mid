using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Alif", "18-38055-2", 2.5f);
            Student s2 = new Student("Mamnun", "18-38257-2", 3.9f);
            Department d1 = new Department("Computer Science", "CSE");
            s1.Department = d1;
            s2.Department = d1;
            d1.AddStudent(s1);
            d1.AddStudent(s2);
            d1.AllStudents();
        }
    }
}
