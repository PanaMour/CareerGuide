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
    public partial class Home : Form
    {
        string username = "";
        public Home()
        {
            InitializeComponent();
        }

        public Home(string arg)
        {
            InitializeComponent();
            label2.Text = arg;
            username = arg;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Course(username).ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Course(username).ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Course(username).ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Course(username).ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Course(username).ShowDialog();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Course(username).ShowDialog();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Grades(username).ShowDialog();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().ShowDialog();
            this.Close();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["CareerGuide"].ConnectionString;
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT course_name FROM course WHERE semester = @semester";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@semester", 1);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        int i = 1;
                        while (reader.Read() && i <= 4)
                        {
                            // Get the course name
                            string courseName = reader.GetString(0);

                            // Assign the course name to a button
                            switch (i)
                            {
                                case 1:
                                    button1.Text = courseName;
                                    break;
                                case 2:
                                    button2.Text = courseName;
                                    break;
                                case 3:
                                    button3.Text = courseName;
                                    break;
                                case 4:
                                    button4.Text = courseName;
                                    break;
                            }

                            i++;
                        }
                    }
                }

                conn.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected semester
            int semester = Convert.ToInt32(comboBox1.SelectedItem.ToString().Split(' ')[1]);

            // Clear the text of all buttons first
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";

            string connectionString = ConfigurationManager.ConnectionStrings["CareerGuide"].ConnectionString;
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT course_name FROM course WHERE semester = @semester";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@semester", semester);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        int i = 1;
                        while (reader.Read() && i <= 4)
                        {
                            // Get the course name
                            string courseName = reader.GetString(0);

                            // Assign the course name to a button
                            switch (i)
                            {
                                case 1:
                                    button1.Text = courseName;
                                    break;
                                case 2:
                                    button2.Text = courseName;
                                    break;
                                case 3:
                                    button3.Text = courseName;
                                    break;
                                case 4:
                                    button4.Text = courseName;
                                    break;
                            }

                            i++;
                        }
                    }
                }

                conn.Close();
            }
        }

    }
}
