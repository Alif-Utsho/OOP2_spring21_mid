using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3__1_
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("Utsho", "18-38055-2", "CSE", (float)3.52);
            s.Name = "Alif Utsho";
            s.showInfo();

            Console.WriteLine("\n");

            Triangle t = new Triangle(3, 4, 5);
            t.showInfo();

            Console.WriteLine("\n");

            Account acc = new Account("Alif", "acc2021", 5000);
            acc.deposit(3000);
            acc.showInfo();

            Console.WriteLine("\n");

            Course c = new Course("OOP2", "CSE-201", 5);
            c.CourseCredit = 3;
            c.showInfo();

            Console.ReadKey();
        }
    }
}
