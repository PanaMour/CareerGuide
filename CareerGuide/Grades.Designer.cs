namespace CareerGuide
{
    partial class Grades
    {
        private System.ComponentModel.IContainer components = null;
        private Label labelStudentName;
        private Label labelSemester;
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
            labelSemester = new Label();
            dataGridViewGrades = new DataGridView();
            backButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGrades).BeginInit();
            SuspendLayout();
            // 
            // labelStudentName
            // 
            labelStudentName.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            labelStudentName.Location = new Point(50, 61);
            labelStudentName.Name = "labelStudentName";
            labelStudentName.Size = new Size(710, 40);
            labelStudentName.TabIndex = 1;
            labelStudentName.Text = "Student: (Name)";
            // 
            // labelSemester
            // 
            labelSemester.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            labelSemester.Location = new Point(50, 111);
            labelSemester.Name = "labelSemester";
            labelSemester.Size = new Size(710, 40);
            labelSemester.TabIndex = 2;
            labelSemester.Text = "Semester: (Semester)";
            labelSemester.Click += labelSemester_Click;
            // 
            // dataGridViewGrades
            // 
            dataGridViewGrades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewGrades.Location = new Point(20, 171);
            dataGridViewGrades.Name = "dataGridViewGrades";
            dataGridViewGrades.Size = new Size(760, 400);
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
            // Grades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 600);
            Controls.Add(dataGridViewGrades);
            Controls.Add(labelSemester);
            Controls.Add(labelStudentName);
            Controls.Add(backButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Grades";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Grades";
            Load += Grades_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewGrades).EndInit();
            ResumeLayout(false);
        }
    }
}