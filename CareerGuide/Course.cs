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
            RearrangeContent();
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
                            bool gradeFinalExists = !reader.IsDBNull(0);

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

                using (SQLiteTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        string updateVisualClicksQuery = "UPDATE student SET visual_clicks = visual_clicks + 1 WHERE id = @id";
                        using (SQLiteCommand cmd = new SQLiteCommand(updateVisualClicksQuery, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@id", StudentInformation.StudentId);
                            cmd.ExecuteNonQuery();
                        }

                        string updateViewedQuery = "UPDATE grade SET viewed = viewed + 1 WHERE student_id = @studentId AND course_id = @courseId";
                        using (SQLiteCommand cmd = new SQLiteCommand(updateViewedQuery, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@studentId", StudentInformation.StudentId);
                            cmd.Parameters.AddWithValue("@courseId", StudentInformation.CourseId);
                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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

        private void button4_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["CareerGuide"].ConnectionString;
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                using (SQLiteTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        string updateAuditoryClicksQuery = "UPDATE student SET auditory_clicks = auditory_clicks + 1 WHERE id = @id";
                        using (SQLiteCommand cmd = new SQLiteCommand(updateAuditoryClicksQuery, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@id", StudentInformation.StudentId);
                            cmd.ExecuteNonQuery();
                        }

                        string updateViewedQuery = "UPDATE grade SET viewed = viewed + 1 WHERE student_id = @studentId AND course_id = @courseId";
                        using (SQLiteCommand cmd = new SQLiteCommand(updateViewedQuery, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@studentId", StudentInformation.StudentId);
                            cmd.Parameters.AddWithValue("@courseId", StudentInformation.CourseId);
                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                conn.Close();
            }

            new AuditoryContent().ShowDialog();
        }

        private void RearrangeContent()
        {
            int visualClicks = 0;
            int auditoryClicks = 0;

            string connectionString = ConfigurationManager.ConnectionStrings["CareerGuide"].ConnectionString;
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT visual_clicks, auditory_clicks FROM student WHERE id = @id";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", StudentInformation.StudentId);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            visualClicks = reader.GetInt32(0);
                            auditoryClicks = reader.GetInt32(1);
                        }
                    }
                }

                conn.Close();
            }

            if (visualClicks >= auditoryClicks)
            {
                pictureBox1.Location = new Point(20, 70);
                pictureBox5.Location = new Point(20, 197);
                button1.Location = new Point(130, 70);
                button4.Location = new Point(130, 197);
            }
            else
            {
                pictureBox5.Location = new Point(20, 70);
                pictureBox1.Location = new Point(20, 197);
                button4.Location = new Point(130, 70);
                button1.Location = new Point(130, 197);
            }
        }
    }
}
