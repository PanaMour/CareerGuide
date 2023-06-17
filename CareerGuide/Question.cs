using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Windows.Forms;

namespace CareerGuide
{
    public partial class Question : Form
    {
        private List<QuestionData> questionDataList;
        private int currentQuestionIndex;
        private int score;
        private int totalGrade;

        public Question()
        {
            InitializeComponent();

            // Initialize the list of question data
            questionDataList = new List<QuestionData>();
            string connectionString = ConfigurationManager.ConnectionStrings["CareerGuide"].ConnectionString;
            // Search the database for questions based on courseId and chapter
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string sql = "SELECT question, choice_a, choice_b, choice_c, answer, grade FROM question WHERE test_id IN " +
                    "(SELECT id FROM test WHERE course_id = @courseId AND chapter = @chapter)";
                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@courseId", StudentInformation.CourseId);
                    command.Parameters.AddWithValue("@chapter", StudentInformation.SelectedChapter);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string question = reader.GetString(0);
                            string choiceA = reader.GetString(1);
                            string choiceB = reader.GetString(2);
                            string choiceC = reader.GetString(3);
                            string answer = reader.GetString(4);
                            int grade = reader.GetInt32(5);

                            QuestionData questionData = new QuestionData(question, choiceA, choiceB, choiceC, answer, grade);
                            questionDataList.Add(questionData);
                            totalGrade += grade;
                        }
                    }
                }
            }

            currentQuestionIndex = 0;
            score = 0;

            // Display the first question
            DisplayQuestion();
        }

        private void DisplayQuestion()
        {
            if (currentQuestionIndex >= 0 && currentQuestionIndex < questionDataList.Count)
            {
                QuestionData currentQuestionData = questionDataList[currentQuestionIndex];

                // Update the question label and choices
                questionLabel.Text = currentQuestionData.Question;
                choiceARadioButton.Text = currentQuestionData.ChoiceA;
                choiceBRadioButton.Text = currentQuestionData.ChoiceB;
                choiceCRadioButton.Text = currentQuestionData.ChoiceC;

                // Clear all radio buttons
                choiceARadioButton.Checked = true;
                choiceBRadioButton.Checked = false;
                choiceCRadioButton.Checked = false;
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            // Check the selected answer
            string selectedChoice = null;

            if (choiceARadioButton.Checked)
                selectedChoice = "A";
            else if (choiceBRadioButton.Checked)
                selectedChoice = "B";
            else if (choiceCRadioButton.Checked)
                selectedChoice = "C";

            // Check if the selected answer is correct
            if (questionDataList[currentQuestionIndex].IsAnswerCorrect(selectedChoice))
                score += questionDataList[currentQuestionIndex].Grade;

            // Move to the next question or finish the quiz
            currentQuestionIndex++;
            if (currentQuestionIndex < questionDataList.Count)
            {
                DisplayQuestion();
            }
            else
            {
                double grade1 = 0;
                double grade2 = 0;
                double gradeFinal = 0;

                if (StudentInformation.SelectedChapter == 1)
                {
                    grade1 = score;
                }
                else if (StudentInformation.SelectedChapter == 2)
                {
                    grade2 = score;
                }
                else if (StudentInformation.SelectedChapter == 3)
                {
                    gradeFinal = score;

                    // Retrieve grade1 and grade2 from the grade table
                    using (SQLiteConnection connection = new SQLiteConnection(ConfigurationManager.ConnectionStrings["CareerGuide"].ConnectionString))
                    {
                        connection.Open();

                        using (SQLiteCommand cmd = new SQLiteCommand(connection))
                        {
                            cmd.CommandText = "SELECT grade1, grade2 FROM grade WHERE student_id = @studentId AND course_id = @courseId";
                            cmd.Parameters.AddWithValue("@studentId", StudentInformation.StudentId);
                            cmd.Parameters.AddWithValue("@courseId", StudentInformation.CourseId);

                            using (SQLiteDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    grade1 = reader.IsDBNull(0) ? 0 : reader.GetDouble(0);
                                    grade2 = reader.IsDBNull(1) ? 0 : reader.GetDouble(1);
                                }
                            }
                        }

                        double finalGrade = grade1 * 0.1 + grade2 * 0.1 + gradeFinal * 0.8;

                        using (SQLiteCommand command = new SQLiteCommand(connection))
                        {
                            command.CommandText = "UPDATE grade SET grade = @finalGrade WHERE student_id = @studentId AND course_id = @courseId";
                            command.Parameters.AddWithValue("@finalGrade", finalGrade);
                            command.Parameters.AddWithValue("@studentId", StudentInformation.StudentId);
                            command.Parameters.AddWithValue("@courseId", StudentInformation.CourseId);
                            command.ExecuteNonQuery();
                        }
                    }
                }

                // Update the grade in the grade table
                using (SQLiteConnection connection = new SQLiteConnection(ConfigurationManager.ConnectionStrings["CareerGuide"].ConnectionString))
                {
                    connection.Open();

                    using (SQLiteCommand command = new SQLiteCommand(connection))
                    {
                        if (StudentInformation.SelectedChapter == 1)
                        {
                            command.CommandText = "UPDATE grade SET grade1 = @grade WHERE student_id = @studentId AND course_id = @courseId";
                            command.Parameters.AddWithValue("@grade", grade1);
                            Test testForm = Application.OpenForms.OfType<Test>().FirstOrDefault();
                            if (testForm != null)
                            {
                                testForm.EnableChapter2Button();
                            }
                        }
                        else if (StudentInformation.SelectedChapter == 2)
                        {
                            command.CommandText = "UPDATE grade SET grade2 = @grade WHERE student_id = @studentId AND course_id = @courseId";
                            command.Parameters.AddWithValue("@grade", grade2);
                            Test testForm = Application.OpenForms.OfType<Test>().FirstOrDefault();
                            if (testForm != null)
                            {
                                testForm.EnableChapter3Button();
                            }
                        }
                        else if (StudentInformation.SelectedChapter == 3)
                        {
                            command.CommandText = "UPDATE grade SET grade_final = @grade WHERE student_id = @studentId AND course_id = @courseId";
                            command.Parameters.AddWithValue("@grade", gradeFinal);
                            Test testForm = Application.OpenForms.OfType<Test>().FirstOrDefault();
                            if (testForm != null)
                            {
                                testForm.DisableChapter3Button();
                            }
                        }

                        command.Parameters.AddWithValue("@studentId", StudentInformation.StudentId);
                        command.Parameters.AddWithValue("@courseId", StudentInformation.CourseId);
                        command.ExecuteNonQuery();
                    }
                }

                // Calculate the score as a percentage
                double scorePercentage = (double)score / totalGrade * 100;

                MessageBox.Show($"Quiz completed!\nYour score: {score} / {totalGrade} = {scorePercentage:F2}%");

                // Close the form and go back to Test.cs
                this.Close();
            }
        }


        // Helper class for representing question data
        public class QuestionData
        {
            public string Question { get; set; }
            public string ChoiceA { get; set; }
            public string ChoiceB { get; set; }
            public string ChoiceC { get; set; }
            public string Answer { get; set; }
            public int Grade { get; set; }

            public QuestionData(string question, string choiceA, string choiceB, string choiceC, string answer, int grade)
            {
                Question = question;
                ChoiceA = choiceA;
                ChoiceB = choiceB;
                ChoiceC = choiceC;
                Answer = answer;
                Grade = grade;
            }

            public bool IsAnswerCorrect(string selectedChoice)
            {
                return Answer.Equals(selectedChoice, StringComparison.OrdinalIgnoreCase);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, AppDomain.CurrentDomain.BaseDirectory + "careerguide.chm", HelpNavigator.TopicId, "16");
        }
    }
}
