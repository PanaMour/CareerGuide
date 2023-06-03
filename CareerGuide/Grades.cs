﻿using System;
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
    public partial class Grades : Form
    {
        public Grades()
        {
            InitializeComponent();
            comboBox1.Text = "Semester 1";
            labelStudentName.Text = "Student: " + StudentInformation.StudentName;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Home().ShowDialog();
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
                c.id AS 'Course ID', 
                c.course_name AS 'Course Name', 
                c.semester AS 'Semester',
                g.grade AS 'Grade'
            FROM 
                grade AS g
            JOIN 
                course AS c ON g.course_id = c.id 
            WHERE 
                g.student_id = @studentId AND c.semester = @semester";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@studentId", StudentInformation.StudentId);
                    cmd.Parameters.AddWithValue("@semester", 1);

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int semester = Convert.ToInt32(comboBox1.SelectedItem.ToString().Split(' ')[1]);

            string connectionString = ConfigurationManager.ConnectionStrings["CareerGuide"].ConnectionString;

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = @"
            SELECT 
                c.id AS 'Course ID', 
                c.course_name AS 'Course Name', 
                c.semester AS 'Semester',
                g.grade AS 'Grade'
            FROM 
                grade AS g
            JOIN 
                course AS c ON g.course_id = c.id 
            WHERE 
                g.student_id = @studentId AND c.semester = @semester";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@studentId", StudentInformation.StudentId);
                    cmd.Parameters.AddWithValue("@semester", semester);

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



    }
}
