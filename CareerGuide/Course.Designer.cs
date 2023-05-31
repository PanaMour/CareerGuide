namespace CareerGuide
{
    partial class Course
    {
        private System.ComponentModel.IContainer components = null;
        private Button buttonBack;
        private Panel panelFiles;
        private Panel panelTests;
        private Panel panelQuestionnaires;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Course));
            buttonBack = new Button();
            panelFiles = new Panel();
            panelTests = new Panel();
            panelQuestionnaires = new Panel();
            SuspendLayout();
            // 
            // buttonBack
            // 
            buttonBack.BackColor = Color.FromArgb(66, 139, 202);
            buttonBack.FlatStyle = FlatStyle.Flat;
            buttonBack.ForeColor = Color.White;
            buttonBack.Location = new Point(20, 20);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(80, 30);
            buttonBack.TabIndex = 1;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += buttonBack_Click;
            // 
            // panelFiles
            // 
            panelFiles.BorderStyle = BorderStyle.FixedSingle;
            panelFiles.Location = new Point(20, 70);
            panelFiles.Name = "panelFiles";
            panelFiles.Size = new Size(760, 150);
            panelFiles.TabIndex = 2;
            // 
            // panelTests
            // 
            panelTests.BorderStyle = BorderStyle.FixedSingle;
            panelTests.Location = new Point(20, 230);
            panelTests.Name = "panelTests";
            panelTests.Size = new Size(760, 150);
            panelTests.TabIndex = 3;
            // 
            // panelQuestionnaires
            // 
            panelQuestionnaires.BorderStyle = BorderStyle.FixedSingle;
            panelQuestionnaires.Location = new Point(20, 390);
            panelQuestionnaires.Name = "panelQuestionnaires";
            panelQuestionnaires.Size = new Size(760, 150);
            panelQuestionnaires.TabIndex = 4;
            // 
            // Course
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 600);
            Controls.Add(panelQuestionnaires);
            Controls.Add(panelTests);
            Controls.Add(panelFiles);
            Controls.Add(buttonBack);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Course";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Course";
            ResumeLayout(false);
        }
    }
}
