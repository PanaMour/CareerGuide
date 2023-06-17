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
    public partial class Course : Form
    {
        public Course()
        {
            InitializeComponent();
            Questionnaire_Enable(null, null);
        }

        private void Course_Load(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Home().ShowDialog();
            this.Close();
        }
        private void Questionnaire_Enable(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["CareerGuide"].ConnectionString;
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                // Retrieve grades from the database
                string query = "SELECT grade_final FROM grade WHERE student_id = @studentId AND course_id = @courseId";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@studentId", StudentInformation.StudentId);
                    cmd.Parameters.AddWithValue("@courseId", StudentInformation.CourseId);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            bool gradeFinalExists = !reader.IsDBNull(0); // Check if the value is null for column index 0

                            if (gradeFinalExists)
                                enableQuestionnaire();
                        }
                    }
                }

                conn.Close();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["CareerGuide"].ConnectionString;
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                // Update the grade table and increment the value of viewed by 1
                string query = "UPDATE grade SET viewed = viewed + 1 WHERE student_id = @studentId AND course_id = @courseId";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@studentId", StudentInformation.StudentId);
                    cmd.Parameters.AddWithValue("@courseId", StudentInformation.CourseId);
                    cmd.ExecuteNonQuery();
                }

                conn.Close();
            }

            new Content().ShowDialog();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Test().ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Questionnaire().ShowDialog();
            this.Close();
        }

        private void enableQuestionnaire()
        {
            button3.Enabled = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, AppDomain.CurrentDomain.BaseDirectory + "careerguide.chm", HelpNavigator.TopicId, "13");
        }
    }
}
