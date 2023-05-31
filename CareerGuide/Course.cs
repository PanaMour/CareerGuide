using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CareerGuide
{
    public partial class Course : Form
    {
        String username = "";
        int id = 0;
        int courseId = 0;
        public Course()
        {
            InitializeComponent();
        }
        public Course(string arg, int arg2, int arg3)
        {
            InitializeComponent();
            username = arg;
            id = arg2;
            courseId = arg3;
        }

        private void Course_Load(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Home(username, id).ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Content(courseId).ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
