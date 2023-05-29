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
    public partial class Grades : Form
    {
        String username = "";
        public Grades()
        {
            InitializeComponent();
        }
        public Grades(string arg)
        {
            InitializeComponent();
            username = arg;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Home(username).ShowDialog();
            this.Close();
        }

        private void dataGridViewGrades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Grades_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["CareerGuide"].ConnectionString;

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = @"
            SELECT 
                c.course_name, 
                g.grade 
            FROM 
                grade AS g
            JOIN 
                course AS c ON g.course_id = c.id 
            WHERE 
                g.student_id = @studentId";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@studentId", 2);

                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dataGridViewGrades.DataSource = dt;
                    }
                }

                conn.Close();
            }
        }

        private void labelSemester_Click(object sender, EventArgs e)
        {

        }
    }
}
