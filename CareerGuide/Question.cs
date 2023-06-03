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
                string sql = "SELECT question, choice_a, choice_b, choice_c FROM question WHERE test_id IN " +
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

                            QuestionData questionData = new QuestionData(question, choiceA, choiceB, choiceC);
                            questionDataList.Add(questionData);
                        }
                    }
                }
            }

            currentQuestionIndex = 0;

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
                choiceARadioButton.Checked = false;
                choiceBRadioButton.Checked = false;
                choiceCRadioButton.Checked = false;
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            // Check the selected answer
            int selectedChoice = -1;

            if (choiceARadioButton.Checked)
                selectedChoice = 0;
            else if (choiceBRadioButton.Checked)
                selectedChoice = 1;
            else if (choiceCRadioButton.Checked)
                selectedChoice = 2;

            // Perform actions with the selected answer
            // ...

            // Move to the next question or finish the quiz
            currentQuestionIndex++;
            if (currentQuestionIndex < questionDataList.Count)
            {
                DisplayQuestion();
            }
            else
            {
                MessageBox.Show("Quiz completed!");
                // Perform any actions you want after the quiz is completed
            }
        }

        // Helper class for representing question data
        public class QuestionData
        {
            public string Question { get; set; }
            public string ChoiceA { get; set; }
            public string ChoiceB { get; set; }
            public string ChoiceC { get; set; }

            public QuestionData(string question, string choiceA, string choiceB, string choiceC)
            {
                Question = question;
                ChoiceA = choiceA;
                ChoiceB = choiceB;
                ChoiceC = choiceC;
            }
        }
    }
}
