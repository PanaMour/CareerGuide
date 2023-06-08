using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Configuration;

namespace CareerGuide
{
    public partial class Recommendation : Form
    {
        public Recommendation()
        {
            InitializeComponent();
            InitializeRecommendation();
        }

        private void InitializeRecommendation()
        {
            // Set the labels' text and style them professionally
            labelTitle.Text = "Possible Career Paths";
            labelTitle.Font = new Font("Arial", 18, FontStyle.Bold);
            labelTitle.ForeColor = Color.FromArgb(64, 64, 64);

            labelDescription1.Text = "Based on your performance on these courses:";
            labelDescription1.Font = new Font("Arial", 14, FontStyle.Regular);
            labelDescription1.ForeColor = Color.FromArgb(64, 64, 64);

            labelDescription2.Text = "We recommend the career:";
            labelDescription2.Font = new Font("Arial", 14, FontStyle.Regular);
            labelDescription2.ForeColor = Color.FromArgb(64, 64, 64);

            // Fetch the recommended career and related courses from the database
            string recommendedCareer = GetRecommendedCareer();
            List<string> relatedCourses = GetRelatedCourses();

            // Display the recommended career and related courses in the labels
            labelRecommendedCareer.Text = recommendedCareer;
            labelRelatedCourses.Text = string.Join(", ", relatedCourses);
        }

        private string GetRecommendedCareer()
        {
            double maxScore = 0;
            string recommendedCareer = string.Empty;

            string connectionString = ConfigurationManager.ConnectionStrings["CareerGuide"].ConnectionString;

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                // Fetch all final scores and corresponding grade values from the database
                string query = "SELECT final_score, grade FROM grade WHERE final_score IS NOT NULL";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            double finalScore = reader.GetDouble(0);
                            double grade = reader.GetDouble(1);

                            double careerScore = (finalScore / 25.0) * grade;

                            if (careerScore > maxScore)
                            {
                                maxScore = careerScore;
                                recommendedCareer = GetCareerNameFromCourseId(StudentInformation.CourseId);
                                MessageBox.Show(recommendedCareer, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }

                conn.Close();
            }

            return recommendedCareer;
        }

        private List<string> GetRelatedCourses()
        {
            List<string> relatedCourses = new List<string>();

            string connectionString = ConfigurationManager.ConnectionStrings["CareerGuide"].ConnectionString;

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                // Fetch all courses related to the recommended career
                string query = "SELECT course_name FROM course WHERE career1 = @career OR career2 = @career OR career3 = @career";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@career", labelRecommendedCareer.Text);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string courseName = reader.GetString(0);
                            relatedCourses.Add(courseName);
                        }
                    }
                }

                conn.Close();
            }

            return relatedCourses;
        }

        private string GetCareerNameFromCourseId(int courseId)
        {
            string careerName = string.Empty;

            string connectionString = ConfigurationManager.ConnectionStrings["CareerGuide"].ConnectionString;

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                // Fetch the career1 for the given courseId
                string query = "SELECT career1 FROM course WHERE id = @courseId";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@courseId", courseId);

                    object result = cmd.ExecuteScalar();
                    if (result != null && !Convert.IsDBNull(result))
                    {
                        careerName = Convert.ToString(result);
                    }
                }

                conn.Close();
            }

            return careerName;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            // Handle back button click event
            this.Hide();
            new Home().ShowDialog();
            this.Close();
        }
    }
}
