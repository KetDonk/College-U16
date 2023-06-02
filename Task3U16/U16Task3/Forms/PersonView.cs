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
    public partial class PersonView : Form
    {
        Student selStudent = null; // Reference to the selected student

        public PersonView(Student student)
        {
            selStudent = student; // Store the selected student
            InitializeComponent();
        }

        public void AddGCSE(GCSE gcseToAdd)
        {
            // Get the reference to the main form
            var mainForm = Application.OpenForms.OfType<Main>().Single();

            // Add the GCSE to the selected student using their ID
            mainForm.addGCSE(gcseToAdd, Int32.Parse(selStudent.getID()));
        }

        private void Person_Load(object sender, EventArgs e)
        {
            this.Text = selStudent.getName() + " (" + selStudent.getID() + ")"; // Set the form title

            // Add student details to list boxes
            listBox1.Items.Add(selStudent.getID());
            listBox2.Items.Add("ID: ");

            listBox1.Items.Add(selStudent.getName());
            listBox2.Items.Add("Name: ");

            listBox1.Items.Add(selStudent.getDoB());
            listBox2.Items.Add("DoB: ");

            Course course = selStudent.getCourse();

            listBox1.Items.Add(course.getTitle());
            listBox2.Items.Add("Course Title: ");

            listBox1.Items.Add(course.getGrade());
            listBox2.Items.Add("Course Grade: ");

            if (selStudent.getGCSECount() > 0)
            {
                // Add GCSE details to list boxes
                foreach (GCSE gsce in selStudent.GetGCSEs())
                {
                    listBox1.Items.Add(gsce.getGrade());
                    listBox2.Items.Add(gsce.getTitle());
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Open the form to add a new GCSE
            AddGCSE form = new AddGCSE();
            form.Show();
        }
    }
}
