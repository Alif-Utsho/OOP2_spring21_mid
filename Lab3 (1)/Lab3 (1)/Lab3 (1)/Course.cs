using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3__1_
{
    class Course
    {
        string courseName, courseCode;
        int courseCredit;
        public Course(string courseName, string courseCode, int courseCredit)
        {
            this.courseName = courseName;
            this.courseCode = courseCode;
            this.courseCredit = courseCredit;
        }

        public void showInfo()
        {
            Console.WriteLine("Course name: " + courseName);
            Console.WriteLine("Course code: " + courseCode);
            Console.WriteLine("Course credit: " + courseCredit);
        }

        public string CourseName
        {
            get { return courseName; }
            set { courseName = value; }
        }

        public string CourseCode
        {
            get { return courseCode; }
            set { courseCode = value; }
        }

        public int CourseCredit
        {
            get { return courseCredit; }
            set { courseCredit = value; }
        }

    }
}
