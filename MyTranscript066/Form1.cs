using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTranscript066
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class Course
        {
            public string CourseID { get; set; }
            public string CourseName { get; set; }
            public string CourseCredit { get; set; }
            public string Grade { get; set; }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void AddGrade(object sender, EventArgs e)
        {
            Course newCourse = new Course();
            newCourse.CourseID = textBox1.Text;
            newCourse.CourseName = textBox2.Text;
            newCourse.CourseCredit = textBox3.Text;
            newCourse.Grade = textBox4.Text;
        }
    }
}
