using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentSystem
{
    class Student : Person
    {
        private string course;

        public void setCourse(string newCourse)
        {
            course = newCourse;
        }

        public string getCourse()
        {
            return course;
        }
    }
}
