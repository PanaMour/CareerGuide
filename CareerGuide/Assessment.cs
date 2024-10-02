using System;
using System.Collections.Generic;
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
    public partial class Assessment : Form
    {
        private bool isSubmitted = false;
        private int analyticalScore = 0;
        private int creativeScore = 0;
        private int practicalScore = 0;

        public Assessment()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Course().ShowDialog();
            this.Close();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (IsRadioButtonSelected(groupBox1) &&
                IsRadioButtonSelected(groupBox2) &&
                IsRadioButtonSelected(groupBox3) &&
                IsRadioButtonSelected(groupBox4) &&
                IsRadioButtonSelected(groupBox5))
            {
                isSubmitted = true;
                CalculateScores();
                string role = DetermineRole();
                UpdateStudentRole(role);
                MessageBox.Show($"Assessment submitted successfully! Your role: {role}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                new Home().ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please answer all the questions.", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool IsRadioButtonSelected(GroupBox groupBox)
        {
            return groupBox.Controls.OfType<RadioButton>().Any(rb => rb.Checked);
        }

        private void CalculateScores()
        {
            analyticalScore = GetScoreForRole(groupBox1, "Analytical") +
                              GetScoreForRole(groupBox2, "Analytical") +
                              GetScoreForRole(groupBox3, "Analytical") +
                              GetScoreForRole(groupBox4, "Analytical") +
                              GetScoreForRole(groupBox5, "Analytical");

            creativeScore = GetScoreForRole(groupBox1, "Creative") +
                            GetScoreForRole(groupBox2, "Creative") +
                            GetScoreForRole(groupBox3, "Creative") +
                            GetScoreForRole(groupBox4, "Creative") +
                            GetScoreForRole(groupBox5, "Creative");

            practicalScore = GetScoreForRole(groupBox1, "Practical") +
                             GetScoreForRole(groupBox2, "Practical") +
                             GetScoreForRole(groupBox3, "Practical") +
                             GetScoreForRole(groupBox4, "Practical") +
                             GetScoreForRole(groupBox5, "Practical");
        }

        private int GetScoreForRole(GroupBox groupBox, string role)
        {
            RadioButton selectedRadioButton = groupBox.Controls.OfType<RadioButton>().FirstOrDefault(rb => rb.Checked);
            if (selectedRadioButton != null)
            {
                if (selectedRadioButton.Tag != null && selectedRadioButton.Tag.ToString() == role)
                {
                    return 1;
                }
            }
            return 0;
        }

        private string DetermineRole()
        {
            if (analyticalScore >= creativeScore && analyticalScore >= practicalScore)
            {
                return "Analytical Researcher";
            }
            else if (creativeScore >= analyticalScore && creativeScore >= practicalScore)
            {
                return "Creative Innovator";
            }
            else
            {
                return "Practical System Builder";
            }
        }

        private void UpdateStudentRole(string role)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["CareerGuide"].ConnectionString;

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = "UPDATE student SET role = @role WHERE id = @id";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@role", role);
                    cmd.Parameters.AddWithValue("@id", StudentInformation.StudentId);
                    cmd.ExecuteNonQuery();
                }

                conn.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, AppDomain.CurrentDomain.BaseDirectory + "careerguide.chm", HelpNavigator.TopicId, "17");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Home().ShowDialog();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, AppDomain.CurrentDomain.BaseDirectory + "careerguide.chm", HelpNavigator.TopicId, "17");
        }

        private void Assessment_Load(object sender, EventArgs e)
        {

        }
    }
}
