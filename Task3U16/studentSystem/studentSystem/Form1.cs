using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studentSystem
{
    public partial class Form1 : Form
    {
        // first we need an array to store our students in
        Student[] students = new Student[] { };
        public Form1()
        {
            InitializeComponent();
            Test test = new Test();
            foreach (Student student in test.getTestStudents())
            {
                students = students.Append(student).ToArray();
            }
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            //this button adds students to the array using input from the text boxes
            Student student = new Student();
            try
            {
                student.setID(Int32.Parse(txtID.Text));
                student.setName(txtName.Text);
                student.setCourse(txtCourse.Text);
                students = students.Append(student).ToArray();
                refreshListBox();
                txtID.Text = null;
                txtName.Text = null;
                txtCourse.Text = null;
            }
            catch
            {
                txtID.Text = "Must be numeric";
            }
        }

        private void btnShowStudents_Click(object sender, EventArgs e)
        {
            //this button will go through all students and display the data in the rich text box
            txtView.Text = null;
            if (students.Length != 0)
            {
                foreach (Student student in students)
                {
                    txtView.AppendText(student.getID().ToString() + Environment.NewLine);
                    txtView.AppendText(student.getName() + Environment.NewLine);
                    txtView.AppendText(student.getCourse() + Environment.NewLine + Environment.NewLine);
                }
            }
            else
            {
                txtView.Text = "No student data found";
            }

        }

        public void refreshListBox()
        {
            listBox1.Items.Clear();
            foreach (Student student in students)
            {
                listBox1.Items.Add("ID:" + student.getID() + "- Name: " + student.getName());
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSingleStudent.Text = null;
            Student student = students[listBox1.SelectedIndex];
            txtSingleStudent.AppendText("ID:"+student.getID().ToString() + Environment.NewLine + "Name:"+student.getName() + Environment.NewLine + "Course:"+ student.getCourse());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //create a temp array
            Student[] temp = new Student[] { };
            //use a for loop 
            for (int i = 0; i < students.Length; i++)
            {
                if (i != listBox1.SelectedIndex)
                {
                    temp = temp.Append(students[i]).ToArray();
                }
            }
            students = temp;
            refreshListBox();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //use a bool as a flag
            Boolean flag = false;
            foreach (Student student in students)
            {
                if (student.getName() == txtSearch.Text)
                {
                    MessageBox.Show(student.getID().ToString() + " " + student.getName() + " " + student.getCourse(), "Student found");
                    flag = true;
                }
            }
            if (flag == false)
            {
                MessageBox.Show("Sorry, no student found with that name.", "404 - Student not found");
            }
        }
    }
}

