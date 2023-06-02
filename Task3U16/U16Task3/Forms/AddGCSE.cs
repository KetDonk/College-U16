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
    public partial class AddGCSE : Form
    {
        public AddGCSE()
        {
            InitializeComponent();
        }

        // Event handler for the button click event
        private void button1_Click(object sender, EventArgs e)
        {
            // Create a new instance of the GCSE class
            GCSE newGCSE = new GCSE();

            // Set the grade and title of the new GCSE based on the text entered in the text boxes
            newGCSE.setGrade(this.gradeBox.Text);
            newGCSE.setTitle(this.titleBox.Text);

            // Get the instance of the PersonView form that is currently open
            var viewForm = Application.OpenForms.OfType<PersonView>().Single();

            // Call the AddGCSE method of the PersonView form, passing the new GCSE object
            viewForm.AddGCSE(newGCSE);
        }
    }
}