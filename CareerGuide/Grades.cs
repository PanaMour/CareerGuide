﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CareerGuide
{
    public partial class Grades : Form
    {
        public Grades()
        {
            InitializeComponent();
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

        }
    }
}
