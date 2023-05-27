namespace CareerGuide
{
    partial class Course
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Panel panelFiles;
        private System.Windows.Forms.Panel panelTests;
        private System.Windows.Forms.Panel panelQuestionnaires;

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
            this.buttonBack = new System.Windows.Forms.Button();
            this.panelFiles = new System.Windows.Forms.Panel();
            this.panelTests = new System.Windows.Forms.Panel();
            this.panelQuestionnaires = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(139)))), ((int)(((byte)(202)))));
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.ForeColor = System.Drawing.Color.White;
            this.buttonBack.Location = new System.Drawing.Point(20, 20);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(80, 30);
            this.buttonBack.TabIndex = 1;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // panelFiles
            // 
            this.panelFiles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFiles.Location = new System.Drawing.Point(20, 70);
            this.panelFiles.Name = "panelFiles";
            this.panelFiles.Size = new System.Drawing.Size(760, 150);
            this.panelFiles.TabIndex = 2;
            // 
            // panelTests
            // 
            this.panelTests.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTests.Location = new System.Drawing.Point(20, 230);
            this.panelTests.Name = "panelTests";
            this.panelTests.Size = new System.Drawing.Size(760, 150);
            this.panelTests.TabIndex = 3;
            // 
            // panelQuestionnaires
            // 
            this.panelQuestionnaires.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelQuestionnaires.Location = new System.Drawing.Point(20, 390);
            this.panelQuestionnaires.Name = "panelQuestionnaires";
            this.panelQuestionnaires.Size = new System.Drawing.Size(760, 150);
            this.panelQuestionnaires.TabIndex = 4;
            // 
            // Course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panelQuestionnaires);
            this.Controls.Add(this.panelTests);
            this.Controls.Add(this.panelFiles);
            this.Controls.Add(this.buttonBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Course";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Course";
            this.ResumeLayout(false);
        }
    }
}
