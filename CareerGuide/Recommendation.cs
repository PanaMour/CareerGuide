using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

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
            labelTitle.Text = "Possible Career Paths";

            labelDescription1.Text = "Recommended postgraduate program based on performance analysis:";
            labelDescription1.Font = new Font("Arial", 14, FontStyle.Regular);
            labelDescription1.ForeColor = Color.FromArgb(64, 64, 64);

            labelDescription2.Text = "We recommend the career:";
            labelDescription2.Font = new Font("Arial", 14, FontStyle.Regular);
            labelDescription2.ForeColor = Color.FromArgb(64, 64, 64);

            string recommendedCareer = GetRecommendedCareer();

            labelRecommendedCareer.Text = recommendedCareer;

            string postgraduateProgram = GetPostgraduateProgram(recommendedCareer);
            labelPostgraduateProgram.Text = postgraduateProgram;
        }

        private string GetPostgraduateProgram(string recommendedCareer)
        {
            switch (recommendedCareer)
            {
                case "Researcher":
                    return "Ph.D. in Computer Science";

                case "Data Scientist":
                    return "Master's in Data Science and Analytics";

                case "AI Specialist":
                    return "Master's in Artificial Intelligence and Machine Learning";

                case "Software Developer":
                    return "Master's in Software Engineering with a focus on Software Development";

                case "Software Engineer":
                    return "Master's in Software Engineering with a focus on Software Engineering Practices";

                case "Systems Programmer":
                    return "Master's in Computer Systems with a focus on Systems Programming";

                case "UX Designer":
                    return "Master's in Human-Computer Interaction and User Experience Design";

                case "Network Specialist":
                    return "Master's in Network Engineering with a focus on Network Security";

                default:
                    return "No specific postgraduate program recommendation";
            }
        }

        private string GetRecommendedCareer()
        {
            Dictionary<string, double> careerScores = new Dictionary<string, double>();
            string studentRole = GetStudentRole();
            double roleBonus = 1.2;

            string connectionString = ConfigurationManager.ConnectionStrings["CareerGuide"].ConnectionString;

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT final_score, grade, course_id FROM grade WHERE final_score IS NOT NULL AND student_id = @studentId";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@studentId", StudentInformation.StudentId);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            double finalScore = reader.GetDouble(0);
                            double grade = reader.GetDouble(1);
                            int courseId = reader.GetInt32(2);

                            string career1 = GetCareerNameFromCourseId(courseId, "career1");
                            string career2 = GetCareerNameFromCourseId(courseId, "career2");
                            string career3 = GetCareerNameFromCourseId(courseId, "career3");

                            double career1Score = finalScore * 1.0;
                            double career2Score = finalScore * 0.8;
                            double career3Score = finalScore * 0.5;

                            career1Score = ApplyRoleBonus(career1Score, career1, studentRole, roleBonus);
                            career2Score = ApplyRoleBonus(career2Score, career2, studentRole, roleBonus);
                            career3Score = ApplyRoleBonus(career3Score, career3, studentRole, roleBonus);

                            if (!string.IsNullOrEmpty(career1))
                                AddToCareerScore(careerScores, career1, career1Score);
                            if (!string.IsNullOrEmpty(career2))
                                AddToCareerScore(careerScores, career2, career2Score);
                            if (!string.IsNullOrEmpty(career3))
                                AddToCareerScore(careerScores, career3, career3Score);
                        }
                    }
                }

                conn.Close();
            }
            double maxScore = 0;
            string recommendedCareer = string.Empty;
            foreach (var careerScore in careerScores)
            {
                if (careerScore.Value > maxScore)
                {
                    maxScore = careerScore.Value;
                    recommendedCareer = careerScore.Key;
                }
            }

            return recommendedCareer;
        }

        private string GetStudentRole()
        {
            string role = string.Empty;
            string connectionString = ConfigurationManager.ConnectionStrings["CareerGuide"].ConnectionString;

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                // Query the role for the specific student
                string query = "SELECT role FROM student WHERE student_id = @studentId";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@studentId", StudentInformation.StudentId);

                    object result = cmd.ExecuteScalar();
                    if (result != null && !Convert.IsDBNull(result))
                    {
                        role = Convert.ToString(result);
                    }
                }

                conn.Close();
            }

            return role;
        }

        private double ApplyRoleBonus(double careerScore, string career, string studentRole, double roleBonus)
        {
            // Adjust scores based on the student's role and career
            if (studentRole == "Analytical Researcher" && (career == "Researcher" || career == "Data Scientist" || career == "AI Specialist"))
            {
                return careerScore * roleBonus;
            }
            else if (studentRole == "Creative Innovator" && (career == "UX Designer" || career == "Software Developer" || career == "Software Engineer"))
            {
                return careerScore * roleBonus;
            }
            else if (studentRole == "Practical System Builder" && (career == "Systems Programmer" || career == "Network Specialist"))
            {
                return careerScore * roleBonus;
            }
            return careerScore;
        }

        private void AddToCareerScore(Dictionary<string, double> careerScores, string career, double score)
        {
            if (careerScores.ContainsKey(career))
                careerScores[career] += score;
            else
                careerScores[career] = score;
        }

        private string GetCareerNameFromCourseId(int courseId, string careerColumn)
        {
            string careerName = string.Empty;

            string connectionString = ConfigurationManager.ConnectionStrings["CareerGuide"].ConnectionString;

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = $"SELECT {careerColumn} FROM course WHERE id = @courseId";
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
            this.Hide();
            new Home().ShowDialog();
            this.Close();
        }

        private void labelRelatedCourses_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, AppDomain.CurrentDomain.BaseDirectory + "careerguide.chm", HelpNavigator.TopicId, "19");
        }
    }
}
