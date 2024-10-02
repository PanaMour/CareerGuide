namespace CareerGuide
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            label1 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button7 = new Button();
            button8 = new Button();
            button5 = new Button();
            pictureBox1 = new PictureBox();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(15, 13);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(176, 45);
            label1.TabIndex = 1;
            label1.Text = "Welcome, ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.CadetBlue;
            label2.Location = new Point(178, 13);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(111, 45);
            label2.TabIndex = 2;
            label2.Text = "(User)";
            label2.Click += label2_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.Items.AddRange(new object[] { "Semester 1", "Semester 2" });
            comboBox1.Location = new Point(307, 131);
            comboBox1.Margin = new Padding(4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(244, 45);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(327, 208);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(203, 64);
            button1.TabIndex = 4;
            button1.Text = "Course 1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(327, 280);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(203, 64);
            button2.TabIndex = 5;
            button2.Text = "Course 2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(327, 352);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(203, 64);
            button3.TabIndex = 4;
            button3.Text = "Course 3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.Cursor = Cursors.Hand;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(327, 420);
            button4.Margin = new Padding(4);
            button4.Name = "button4";
            button4.Size = new Size(203, 64);
            button4.TabIndex = 3;
            button4.Text = "Course 4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.White;
            button7.Cursor = Cursors.Hand;
            button7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(48, 208);
            button7.Margin = new Padding(4);
            button7.Name = "button7";
            button7.Size = new Size(203, 64);
            button7.TabIndex = 0;
            button7.Text = "View Grades";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.White;
            button8.Cursor = Cursors.Hand;
            button8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button8.Location = new Point(94, 433);
            button8.Margin = new Padding(4);
            button8.Name = "button8";
            button8.Size = new Size(115, 38);
            button8.TabIndex = 6;
            button8.Text = "Sign Out";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.White;
            button5.Cursor = Cursors.Hand;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(48, 352);
            button5.Margin = new Padding(4);
            button5.Name = "button5";
            button5.Size = new Size(203, 64);
            button5.TabIndex = 7;
            button5.Text = "Career Guide";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.helpicon;
            pictureBox1.Location = new Point(499, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(67, 57);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.White;
            button6.Cursor = Cursors.Hand;
            button6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(48, 280);
            button6.Margin = new Padding(4);
            button6.Name = "button6";
            button6.Size = new Size(203, 64);
            button6.TabIndex = 9;
            button6.Text = "Personalized Learning Assessment";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(578, 513);
            Controls.Add(button6);
            Controls.Add(pictureBox1);
            Controls.Add(button5);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            Load += Home_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button7;
        private Button button8;
        private Button button5;
        private PictureBox pictureBox1;
        private Button button6;
    }
}