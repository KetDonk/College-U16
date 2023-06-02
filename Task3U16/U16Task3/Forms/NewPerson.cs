using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using U16Task3.Classes;

namespace U16Task3.Forms
{
    public partial class NewPerson : Form
    {
        public NewPerson()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get the reference to the main form
            var mainForm = Application.OpenForms.OfType<Main>().Single();

            // Create a new course
            Course course = new Course();

            // Set the course title and grade based on the input fields
            course.setTitle(this.courseTitle.Text);
            course.setGrade(this.courseGrade.Text);

            // Add a new person (student) to the main form using the provided details
            mainForm.addPerson(this.nameBox.Text, this.dobBox.Text, course);

            // Close the current form
            this.Close();
        }
    }
}
