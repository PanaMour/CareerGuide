﻿namespace CareerGuide
{
    partial class Grades
    {
        private System.ComponentModel.IContainer components = null;
        private Label labelStudentName;
        private DataGridView dataGridViewGrades;
        private Button backButton; // Added Button

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Grades));
            labelStudentName = new Label();
            dataGridViewGrades = new DataGridView();
            backButton = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGrades).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelStudentName
            // 
            labelStudentName.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            labelStudentName.Location = new Point(50, 61);
            labelStudentName.Name = "labelStudentName";
            labelStudentName.Size = new Size(227, 37);
            labelStudentName.TabIndex = 1;
            labelStudentName.Text = "Student:";
            // 
            // dataGridViewGrades
            // 
            dataGridViewGrades.AllowUserToAddRows = false;
            dataGridViewGrades.AllowUserToDeleteRows = false;
            dataGridViewGrades.AllowUserToOrderColumns = true;
            dataGridViewGrades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewGrades.Location = new Point(20, 171);
            dataGridViewGrades.Name = "dataGridViewGrades";
            dataGridViewGrades.ReadOnly = true;
            dataGridViewGrades.Size = new Size(662, 110);
            dataGridViewGrades.TabIndex = 3;
            dataGridViewGrades.CellContentClick += dataGridViewGrades_CellContentClick;
            // 
            // backButton
            // 
            backButton.BackColor = Color.FromArgb(66, 139, 202);
            backButton.FlatStyle = FlatStyle.Flat;
            backButton.ForeColor = Color.White;
            backButton.Location = new Point(20, 20);
            backButton.Name = "backButton";
            backButton.Size = new Size(80, 30);
            backButton.TabIndex = 4;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Semester 1", "Semester 2" });
            comboBox1.Location = new Point(50, 108);
            comboBox1.Margin = new Padding(4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(244, 45);
            comboBox1.TabIndex = 5;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.CadetBlue;
            label1.Location = new Point(168, 61);
            label1.Name = "label1";
            label1.Size = new Size(514, 37);
            label1.TabIndex = 6;
            label1.Text = "(Name)";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.helpicon;
            pictureBox1.Location = new Point(615, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(67, 57);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Grades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(698, 311);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(dataGridViewGrades);
            Controls.Add(labelStudentName);
            Controls.Add(backButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Grades";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Grades";
            Load += Grades_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewGrades).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        private ComboBox comboBox1;
        private Label label1;
        private PictureBox pictureBox1;
    }
}