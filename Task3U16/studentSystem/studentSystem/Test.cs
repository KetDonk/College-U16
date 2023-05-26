using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentSystem
{
    class Test
    {
        public Student createStudent(int id, string name, string course)
        {
            Student student = new Student();
            student.setID(id);
            student.setName(name);
            student.setCourse(course);
            return student;
        }

        public Student[] getTestStudents()
        {
            return new Student[] { createStudent(1, "Stewie", "Networking"), createStudent(2, "Bryan", "Esports"), createStudent(3, "Meg", "Child care") };
        }

    }
}
