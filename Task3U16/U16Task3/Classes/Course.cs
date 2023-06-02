using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U16Task3.Classes
{
    public class Course
    {
        // Public properties
        public string Title;
        public string Grade;

        // Setter methods

        public void setGrade(string newGrade)
        {
            this.Grade = newGrade;
        }

        public void setTitle(string newTitle)
        {
            this.Title = newTitle;
        }

        // Getter methods

        public string getGrade()
        {
            return this.Grade;
        }

        public string getTitle()
        {
            return this.Title;
        }

        
    }
}

