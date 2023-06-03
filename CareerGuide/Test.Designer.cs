namespace CareerGuide
{
    partial class Test
    {
        private System.ComponentModel.IContainer components = null;

        private Button button1;
        private Button button2;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Test));
            button1 = new Button();
            button2 = new Button();
            buttonBack = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(117, 58);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(117, 58);
            button1.TabIndex = 0;
            button1.Text = "Chapter 1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(117, 127);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(117, 58);
            button2.TabIndex = 1;
            button2.Text = "Chapter 2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // buttonBack
            // 
            buttonBack.BackColor = Color.FromArgb(66, 139, 202);
            buttonBack.FlatStyle = FlatStyle.Flat;
            buttonBack.ForeColor = Color.White;
            buttonBack.Location = new Point(137, 12);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(80, 30);
            buttonBack.TabIndex = 2;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += buttonBack_Click;
            // 
            // Test
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 231);
            Controls.Add(buttonBack);
            Controls.Add(button1);
            Controls.Add(button2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "Test";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Test";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonBack;
    }
}
