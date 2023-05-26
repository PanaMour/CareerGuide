namespace CareerGuide
{
    partial class Grades
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelStudentName;
        private System.Windows.Forms.Label labelSemester;
        private System.Windows.Forms.DataGridView dataGridViewGrades;

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
            this.labelStudentName = new System.Windows.Forms.Label();
            this.labelSemester = new System.Windows.Forms.Label();
            this.dataGridViewGrades = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGrades)).BeginInit();
            this.SuspendLayout();
            // 
            // labelStudentName
            // 
            this.labelStudentName.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelStudentName.Location = new System.Drawing.Point(20, 20);
            this.labelStudentName.Name = "labelStudentName";
            this.labelStudentName.Size = new System.Drawing.Size(760, 40);
            this.labelStudentName.TabIndex = 1;
            this.labelStudentName.Text = "Student: (Name)";
            // 
            // labelSemester
            // 
            this.labelSemester.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSemester.Location = new System.Drawing.Point(20, 70);
            this.labelSemester.Name = "labelSemester";
            this.labelSemester.Size = new System.Drawing.Size(760, 40);
            this.labelSemester.TabIndex = 2;
            this.labelSemester.Text = "Semester: (Semester)";
            // 
            // dataGridViewGrades
            // 
            this.dataGridViewGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGrades.Location = new System.Drawing.Point(20, 130);
            this.dataGridViewGrades.Name = "dataGridViewGrades";
            this.dataGridViewGrades.Size = new System.Drawing.Size(760, 400);
            this.dataGridViewGrades.TabIndex = 3;
            // 
            // Grades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.dataGridViewGrades);
            this.Controls.Add(this.labelSemester);
            this.Controls.Add(this.labelStudentName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Grades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grades";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGrades)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
