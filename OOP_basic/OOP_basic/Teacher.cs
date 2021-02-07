using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_basic2
{
    class Teacher
    {
        string name;
        int id;
        public Teacher(string name, int id)
        {
            this.name = name;
            this.id = id;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        internal void showTeacher()
        {
            Console.WriteLine("Teacher");
            Console.WriteLine("\tName: {0}", name);
            Console.WriteLine("\tID: {0}", id);
        }
    }
}
