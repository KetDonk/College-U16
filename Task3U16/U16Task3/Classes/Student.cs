using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U16Task3.Classes
{
    public class Student : Person
    {
        // Public properties
        public Course Course;
        public GCSE[] GCSEs;

        // Setter methods
        public void setCourse(Course newCourse)
        {
            this.Course = newCourse;
        }

        public void addGCSE(GCSE GCSEToAdd)
        {
            GCSE[] temp = new GCSE[] { };
            temp.Append(GCSEToAdd).ToArray();
            GCSEs = temp;
        }

        // Getter methods
        public int getGCSECount()
        {
            if (GCSEs != null)
            {
                return GCSEs.Length;
            }
            else
            {
                return 0;
            }
        }

        public Course getCourse()
        {
            return this.Course;
        }

        public GCSE[] GetGCSEs()
        {
            return this.GCSEs;
        }
    }
}
