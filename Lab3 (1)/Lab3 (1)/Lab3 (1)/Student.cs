using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3__1_
{
    class Student
    {
        private string name, id, department;
        private float cgpa;
        public Student(string name, string id, string department, float cgpa)
        {
            this.name = name;
            this.id = id;
            this.department = department;
            this.cgpa = cgpa;
        }

        public void showInfo()
        {
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("ID: {0}", id);
            Console.WriteLine("Department: {0}", department);
            Console.WriteLine("CGPA: {0}", cgpa);
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Department
        {
            get { return department; }
            set { department = value; }
        }

        public float Cgpa
        {
            get { return cgpa; }
            set { cgpa = value; }
        }

    }
}
