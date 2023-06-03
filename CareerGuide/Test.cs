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

        }

        private void button2_Click(object sender, EventArgs e)
        {

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

                string query = "SELECT chapter, chapter_name FROM test WHERE course_id = @courseId";
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
                            }
                        }
                    }
                }

                conn.Close();
            }
        }

    }
}
