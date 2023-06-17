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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CareerGuide
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
            Test_Load(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentInformation.SelectedChapter = 1;
            new Question().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StudentInformation.SelectedChapter = 2;
            new Question().ShowDialog();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            StudentInformation.SelectedChapter = 3;
            new Question().ShowDialog();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Course().ShowDialog();
            this.Close();
        }

        private void Test_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["CareerGuide"].ConnectionString;
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                // Retrieve grades from the database
                string query = "SELECT grade1, grade2, grade_final FROM grade WHERE student_id = @studentId AND course_id = @courseId";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@studentId", StudentInformation.StudentId);
                    cmd.Parameters.AddWithValue("@courseId", StudentInformation.CourseId);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Check the values of grade1, grade2, and grade_final
                            bool grade1Exists = !reader.IsDBNull(0);
                            bool grade2Exists = !reader.IsDBNull(1);
                            bool gradeFinalExists = !reader.IsDBNull(2);

                            // Enable/disable buttons based on grades
                            if (grade1Exists)
                                EnableChapter2Button();

                            if (grade2Exists)
                                EnableChapter3Button();

                            if (gradeFinalExists)
                                DisableChapter3Button();
                        }
                    }
                }

                // Retrieve chapter information from the test table
                query = "SELECT chapter, chapter_name FROM test WHERE course_id = @courseId";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@courseId", StudentInformation.CourseId);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Get the chapter number and chapter name
                            int chapter = reader.GetInt32(0);
                            string chapterName = reader.GetString(1);

                            // Assign the chapter name to the corresponding button based on the chapter number
                            switch (chapter)
                            {
                                case 1:
                                    button1.Text = chapterName;
                                    break;
                                case 2:
                                    button2.Text = chapterName;
                                    break;
                                case 3:
                                    button3.Text = chapterName;
                                    break;
                            }
                        }
                    }
                }

                conn.Close();
            }
        }

        public void EnableChapter2Button()
        {
            button2.Enabled = true;
            button1.Enabled = false;
        }
        public void EnableChapter3Button()
        {
            button3.Enabled = true;
            button2.Enabled = false;
        }
        public void DisableChapter3Button()
        {
            button3.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, AppDomain.CurrentDomain.BaseDirectory + "careerguide.chm", HelpNavigator.TopicId, "15");
        }
    }
}
