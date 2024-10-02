using System;
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
    public partial class Assessment : Form
    {
        private Button submitButton;

        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Assessment));
            submitButton = new Button();
            label1 = new Label();
            buttonBack = new Button();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            choiceARadioButton1 = new RadioButton();
            choiceBRadioButton1 = new RadioButton();
            choiceCRadioButton1 = new RadioButton();
            groupBox2 = new GroupBox();
            choiceARadioButton2 = new RadioButton();
            choiceBRadioButton2 = new RadioButton();
            choiceCRadioButton2 = new RadioButton();
            groupBox3 = new GroupBox();
            choiceARadioButton3 = new RadioButton();
            choiceBRadioButton3 = new RadioButton();
            choiceCRadioButton3 = new RadioButton();
            groupBox4 = new GroupBox();
            choiceARadioButton4 = new RadioButton();
            choiceBRadioButton4 = new RadioButton();
            choiceCRadioButton4 = new RadioButton();
            groupBox5 = new GroupBox();
            choiceARadioButton5 = new RadioButton();
            choiceBRadioButton5 = new RadioButton();
            choiceCRadioButton5 = new RadioButton();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            ((ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            ((ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // submitButton
            // 
            submitButton.Location = new Point(154, 724);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(120, 24);
            submitButton.TabIndex = 0;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 55);
            label1.Name = "label1";
            label1.Size = new Size(287, 15);
            label1.TabIndex = 1;
            label1.Text = "1. How do you typically approach solving a problem?";
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(0, 0);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(75, 23);
            buttonBack.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(choiceARadioButton1);
            groupBox1.Controls.Add(choiceBRadioButton1);
            groupBox1.Controls.Add(choiceCRadioButton1);
            groupBox1.Location = new Point(20, 80);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(400, 100);
            groupBox1.TabIndex = 60;
            groupBox1.TabStop = false;
            // 
            // choiceARadioButton1
            // 
            choiceARadioButton1.Location = new Point(14, 20);
            choiceARadioButton1.Name = "choiceARadioButton1";
            choiceARadioButton1.Size = new Size(104, 24);
            choiceARadioButton1.TabIndex = 0;
            choiceARadioButton1.Text = "A) I analyze the problem thoroughly and make data-driven decisions.";
            // 
            // choiceBRadioButton1
            // 
            choiceBRadioButton1.Location = new Point(14, 45);
            choiceBRadioButton1.Name = "choiceBRadioButton1";
            choiceBRadioButton1.Size = new Size(104, 24);
            choiceBRadioButton1.TabIndex = 1;
            choiceBRadioButton1.Text = "B) I brainstorm creative solutions and think outside the box.";
            // 
            // choiceCRadioButton1
            // 
            choiceCRadioButton1.Location = new Point(14, 70);
            choiceCRadioButton1.Name = "choiceCRadioButton1";
            choiceCRadioButton1.Size = new Size(104, 24);
            choiceCRadioButton1.TabIndex = 2;
            choiceCRadioButton1.Text = "C) I rely on practical experience and hands-on experimentation.";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(choiceARadioButton2);
            groupBox2.Controls.Add(choiceBRadioButton2);
            groupBox2.Controls.Add(choiceCRadioButton2);
            groupBox2.Location = new Point(20, 210);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(400, 100);
            groupBox2.TabIndex = 61;
            groupBox2.TabStop = false;
            // 
            // choiceARadioButton2
            // 
            choiceARadioButton2.Location = new Point(14, 20);
            choiceARadioButton2.Name = "choiceARadioButton2";
            choiceARadioButton2.Size = new Size(104, 24);
            choiceARadioButton2.TabIndex = 0;
            choiceARadioButton2.Text = "A) Reading in-depth materials, analyzing data, and understanding the theory.";
            // 
            // choiceBRadioButton2
            // 
            choiceBRadioButton2.Location = new Point(14, 45);
            choiceBRadioButton2.Name = "choiceBRadioButton2";
            choiceBRadioButton2.Size = new Size(104, 24);
            choiceBRadioButton2.TabIndex = 1;
            choiceBRadioButton2.Text = "B) Watching tutorials or demonstrations, visualizing concepts creatively.";
            // 
            // choiceCRadioButton2
            // 
            choiceCRadioButton2.Location = new Point(14, 70);
            choiceCRadioButton2.Name = "choiceCRadioButton2";
            choiceCRadioButton2.Size = new Size(104, 24);
            choiceCRadioButton2.TabIndex = 2;
            choiceCRadioButton2.Text = "C) Jumping straight into real-world applications and learning by doing.";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(choiceARadioButton3);
            groupBox3.Controls.Add(choiceBRadioButton3);
            groupBox3.Controls.Add(choiceCRadioButton3);
            groupBox3.Location = new Point(20, 350);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(400, 100);
            groupBox3.TabIndex = 62;
            groupBox3.TabStop = false;
            // 
            // choiceARadioButton3
            // 
            choiceARadioButton3.Location = new Point(14, 20);
            choiceARadioButton3.Name = "choiceARadioButton3";
            choiceARadioButton3.Size = new Size(104, 24);
            choiceARadioButton3.TabIndex = 0;
            choiceARadioButton3.Text = "A) Research-based projects requiring deep analysis and data study.";
            // 
            // choiceBRadioButton3
            // 
            choiceBRadioButton3.Location = new Point(14, 45);
            choiceBRadioButton3.Name = "choiceBRadioButton3";
            choiceBRadioButton3.Size = new Size(104, 24);
            choiceBRadioButton3.TabIndex = 1;
            choiceBRadioButton3.Text = "B) Projects where I can design and innovate new solutions.";
            // 
            // choiceCRadioButton3
            // 
            choiceCRadioButton3.Location = new Point(14, 70);
            choiceCRadioButton3.Name = "choiceCRadioButton3";
            choiceCRadioButton3.Size = new Size(104, 24);
            choiceCRadioButton3.TabIndex = 2;
            choiceCRadioButton3.Text = "C) Hands-on projects with tangible results and practical applications.";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(choiceARadioButton4);
            groupBox4.Controls.Add(choiceBRadioButton4);
            groupBox4.Controls.Add(choiceCRadioButton4);
            groupBox4.Location = new Point(20, 480);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(400, 100);
            groupBox4.TabIndex = 63;
            groupBox4.TabStop = false;
            // 
            // choiceARadioButton4
            // 
            choiceARadioButton4.Location = new Point(14, 20);
            choiceARadioButton4.Name = "choiceARadioButton4";
            choiceARadioButton4.Size = new Size(104, 24);
            choiceARadioButton4.TabIndex = 0;
            choiceARadioButton4.Text = "A) Independently, with lots of data and analysis.";
            // 
            // choiceBRadioButton4
            // 
            choiceBRadioButton4.Location = new Point(14, 45);
            choiceBRadioButton4.Name = "choiceBRadioButton4";
            choiceBRadioButton4.Size = new Size(104, 24);
            choiceBRadioButton4.TabIndex = 1;
            choiceBRadioButton4.Text = "B) In a collaborative, creative environment.";
            // 
            // choiceCRadioButton4
            // 
            choiceCRadioButton4.Location = new Point(14, 70);
            choiceCRadioButton4.Name = "choiceCRadioButton4";
            choiceCRadioButton4.Size = new Size(104, 24);
            choiceCRadioButton4.TabIndex = 2;
            choiceCRadioButton4.Text = "C) In a hands-on environment with practical tasks.";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(choiceARadioButton5);
            groupBox5.Controls.Add(choiceBRadioButton5);
            groupBox5.Controls.Add(choiceCRadioButton5);
            groupBox5.Location = new Point(20, 610);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(400, 100);
            groupBox5.TabIndex = 64;
            groupBox5.TabStop = false;
            // 
            // choiceARadioButton5
            // 
            choiceARadioButton5.Location = new Point(14, 20);
            choiceARadioButton5.Name = "choiceARadioButton5";
            choiceARadioButton5.Size = new Size(104, 24);
            choiceARadioButton5.TabIndex = 0;
            choiceARadioButton5.Text = "A) Making discoveries or solving complex problems.";
            // 
            // choiceBRadioButton5
            // 
            choiceBRadioButton5.Location = new Point(14, 45);
            choiceBRadioButton5.Name = "choiceBRadioButton5";
            choiceBRadioButton5.Size = new Size(104, 24);
            choiceBRadioButton5.TabIndex = 1;
            choiceBRadioButton5.Text = "B) Designing products or creating new solutions.";
            // 
            // choiceCRadioButton5
            // 
            choiceCRadioButton5.Location = new Point(14, 70);
            choiceCRadioButton5.Name = "choiceCRadioButton5";
            choiceCRadioButton5.Size = new Size(104, 24);
            choiceCRadioButton5.TabIndex = 2;
            choiceCRadioButton5.Text = "C) Developing systems or managing networks.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 190);
            label2.Name = "label2";
            label2.Size = new Size(352, 15);
            label2.TabIndex = 26;
            label2.Text = "2. When learning something new, what is your preferred method?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(79, 332);
            label3.Name = "label3";
            label3.Size = new Size(259, 15);
            label3.TabIndex = 30;
            label3.Text = "3. What type of projects do you enjoy the most?";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(82, 459);
            label4.Name = "label4";
            label4.Size = new Size(212, 15);
            label4.TabIndex = 34;
            label4.Text = "4. How do you prefer to work or study?";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(92, 592);
            label5.Name = "label5";
            label5.Size = new Size(275, 15);
            label5.TabIndex = 38;
            label5.Text = "5. What excites you most about your future career?";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.helpiconquestion;
            pictureBox2.Location = new Point(391, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(48, 39);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 52;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(66, 139, 202);
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = Color.White;
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(80, 30);
            button1.TabIndex = 51;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Assessment
            // 
            BackColor = Color.SeaShell;
            ClientSize = new Size(451, 772);
            Controls.Add(pictureBox2);
            Controls.Add(button1);
            Controls.Add(submitButton);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox4);
            Controls.Add(groupBox5);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Assessment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Assessment";
            Load += Assessment_Load;
            ((ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            ((ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Button buttonBack;
        private PictureBox pictureBox1;
        private RadioButton choiceARadioButton1;
        private RadioButton choiceBRadioButton1;
        private RadioButton choiceCRadioButton1;
        private RadioButton choiceARadioButton2;
        private RadioButton choiceBRadioButton2;
        private RadioButton choiceCRadioButton2;
        private RadioButton choiceARadioButton3;
        private RadioButton choiceBRadioButton3;
        private RadioButton choiceCRadioButton3;
        private RadioButton choiceARadioButton4;
        private RadioButton choiceBRadioButton4;
        private RadioButton choiceCRadioButton4;
        private RadioButton choiceARadioButton5;
        private RadioButton choiceBRadioButton5;
        private RadioButton choiceCRadioButton5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox2;
        private Button button1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
    }
}
