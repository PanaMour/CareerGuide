namespace CareerGuide
{
    partial class Course
    {
        private System.ComponentModel.IContainer components = null;
        private Button buttonBack;

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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
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
            // button1
            // 
            button1.Location = new Point(20, 86);
            button1.Name = "button1";
            button1.Size = new Size(200, 200);
            button1.TabIndex = 2;
            button1.Text = "Content";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(248, 86);
            button2.Name = "button2";
            button2.Size = new Size(200, 200);
            button2.TabIndex = 3;
            button2.Text = "Test";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(475, 86);
            button3.Name = "button3";
            button3.Size = new Size(200, 200);
            button3.TabIndex = 4;
            button3.Text = "Questionnaire";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Course
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(715, 321);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(buttonBack);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Course";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Course";
            ResumeLayout(false);
        }

        private Button button1;
        private Button button2;
        private Button button3;
    }
}
