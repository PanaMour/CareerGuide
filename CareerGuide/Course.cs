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
    public partial class Course : Form
    {
        String username = "";
        int id = 0;
        public Course()
        {
            InitializeComponent();
        }
        public Course(string arg, int arg2)
        {
            InitializeComponent();
            username = arg;
            id = arg2;
        }

        private void Course_Load(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Home(username, id).ShowDialog();
            this.Close();
        }
    }
}
