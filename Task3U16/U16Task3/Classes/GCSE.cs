using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U16Task3.Classes
{
    public class GCSE : Course
    {
        // Override the base class's setGrade method to handle integer grades
        public new void setGrade(int newGrade)
        {
            if (newGrade > 0 && newGrade < 10) // Check if the newGrade value is within the valid range
            {
                this.Grade = newGrade.ToString(); // Set the Grade property to the string representation of newGrade
            }
            else
            {
                this.Grade = "0"; // Set the Grade property to "0" if newGrade is outside the valid range
            }
        }
    }
}
