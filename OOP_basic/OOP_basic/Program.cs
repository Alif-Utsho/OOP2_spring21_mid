using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_basic2;

namespace OOP_basic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Programmer");

            Student std = new Student("Alif Utsho", 380555);
            std.showAll();

            Teacher tcr = new Teacher("Ahmed Tanvir", 505);
            tcr.Name = "Abdul Hamid";
            //tcr.showTeacher();
            Console.WriteLine(tcr.Name);
            Console.WriteLine(tcr.Id);
            

            Console.Write("\nPress any key to exit");
            Console.ReadKey();
        }
    }
}
