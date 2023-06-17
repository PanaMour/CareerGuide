using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CareerGuide
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            comboBox1.Text = "Semester 1";
            label2.Text = StudentInformation.StudentName;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentInformation.CourseId = StudentInformation.CourseId1;
            this.Hide();
            new Course().ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StudentInformation.CourseId = StudentInformation.CourseId2;
            this.Hide();
            new Course().ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StudentInformation.CourseId = StudentInformation.CourseId3;
            this.Hide();
            new Course().ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StudentInformation.CourseId = StudentInformation.CourseId4;
            this.Hide();
            new Course().ShowDialog();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Grades().ShowDialog();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().ShowDialog();
            this.Close();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["CareerGuide"].ConnectionString;
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT id, course_name FROM course WHERE semester = @semester";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@semester", 1);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        int i = 1;
                        while (reader.Read() && i <= 4)
                        {
                            // Get the course name and id
                            int courseId = reader.GetInt32(0);
                            string courseName = reader.GetString(1);

                            // Assign the course name to a button
                            switch (i)
                            {
                                case 1:
                                    button1.Text = courseName;
                                    StudentInformation.CourseId1 = courseId;
                                    break;
                                case 2:
                                    button2.Text = courseName;
                                    StudentInformation.CourseId2 = courseId;
                                    break;
                                case 3:
                                    button3.Text = courseName;
                                    StudentInformation.CourseId3 = courseId;
                                    break;
                                case 4:
                                    button4.Text = courseName;
                                    StudentInformation.CourseId4 = courseId;
                                    break;
                            }

                            i++;
                        }
                    }
                }

                conn.Close();
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Convert the selected semester to an integer.
            int semester = Convert.ToInt32(comboBox1.SelectedItem.ToString().Split(' ')[1]);

            string connectionString = ConfigurationManager.ConnectionStrings["CareerGuide"].ConnectionString;
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT id, course_name FROM course WHERE semester = @semester";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@semester", semester);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        int i = 1;
                        while (reader.Read() && i <= 4)
                        {
                            // Get the course name and ID
                            string courseName = reader.GetString(1);
                            int courseId = reader.GetInt32(0);

                            // Assign the course name to a button and the course ID to the courseId variable
                            switch (i)
                            {
                                case 1:
                                    button1.Text = courseName;
                                    StudentInformation.CourseId1 = courseId;
                                    break;
                                case 2:
                                    button2.Text = courseName;
                                    StudentInformation.CourseId2 = courseId;
                                    break;
                                case 3:
                                    button3.Text = courseName;
                                    StudentInformation.CourseId3 = courseId;
                                    break;
                                case 4:
                                    button4.Text = courseName;
                                    StudentInformation.CourseId4 = courseId;
                                    break;
                            }

                            i++;
                        }
                    }
                }

                conn.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Recommendation().ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, AppDomain.CurrentDomain.BaseDirectory + "careerguide.chm", HelpNavigator.TopicId, "11");
        }
    }
}
