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
    public partial class Questionnaire : Form
    {
        private bool isSubmitted = false;
        private int finalScore = 0;

        public Questionnaire()
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
            // Handle submit button click event
            if (IsRadioButtonSelected(groupBox1) &&
                IsRadioButtonSelected(groupBox2) &&
                IsRadioButtonSelected(groupBox3) &&
                IsRadioButtonSelected(groupBox4) &&
                IsRadioButtonSelected(groupBox5))
            {
                // All radio buttons are selected
                isSubmitted = true;
                CalculateFinalScore();
                SubmitToDatabase();
                MessageBox.Show("Questionnaire submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                new Course().ShowDialog();
                this.Close();
            }
            else
            {
                // At least one group has no radio button selected
                MessageBox.Show("Please answer all the questions.", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool IsRadioButtonSelected(GroupBox groupBox)
        {
            return groupBox.Controls.OfType<RadioButton>().Any(rb => rb.Checked);
        }

        private void CalculateFinalScore()
        {
            finalScore = GetQuestionScore(groupBox1) +
                         GetQuestionScore(groupBox2) +
                         GetQuestionScore(groupBox3) +
                         GetQuestionScore(groupBox4) +
                         GetQuestionScore(groupBox5);
        }

        private int GetQuestionScore(GroupBox groupBox)
        {
            RadioButton selectedRadioButton = groupBox.Controls.OfType<RadioButton>().FirstOrDefault(rb => rb.Checked);
            if (selectedRadioButton != null)
            {
                // Extract the score from the radio button's text
                if (int.TryParse(selectedRadioButton.Text, out int score))
                {
                    return score;
                }
            }
            return 0; // Return 0 if no radio button is selected or an error occurred
        }

        private void SubmitToDatabase()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["CareerGuide"].ConnectionString;

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = "UPDATE grade SET final_score = @finalScore WHERE student_id = @studentId AND course_id = @courseId";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@finalScore", finalScore);
                    cmd.Parameters.AddWithValue("@studentId", StudentInformation.StudentId);
                    cmd.Parameters.AddWithValue("@courseId", StudentInformation.CourseId);
                    MessageBox.Show(finalScore.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmd.ExecuteNonQuery();
                }

                conn.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, AppDomain.CurrentDomain.BaseDirectory + "careerguide.chm", HelpNavigator.TopicId, "17");
        }
    }
}
