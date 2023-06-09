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
    public partial class Questionnaire : Form
    {
        private Label label1, label2, label3, label4, label5;
        private GroupBox groupBox1, groupBox2, groupBox3, groupBox4, groupBox5;
        private RadioButton radioButton1, radioButton2, radioButton3, radioButton4, radioButton5;
        private RadioButton radioButton6, radioButton7, radioButton8, radioButton9, radioButton10;
        private RadioButton radioButton11, radioButton12, radioButton13, radioButton14, radioButton15;
        private RadioButton radioButton16, radioButton17, radioButton18, radioButton19, radioButton20;
        private RadioButton radioButton21, radioButton22, radioButton23, radioButton24, radioButton25;
        private Button submitButton;

        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Questionnaire));
            submitButton = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            radioButton5 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label2 = new Label();
            groupBox2 = new GroupBox();
            radioButton10 = new RadioButton();
            radioButton9 = new RadioButton();
            radioButton8 = new RadioButton();
            radioButton7 = new RadioButton();
            radioButton6 = new RadioButton();
            label3 = new Label();
            groupBox3 = new GroupBox();
            radioButton15 = new RadioButton();
            radioButton14 = new RadioButton();
            radioButton13 = new RadioButton();
            radioButton12 = new RadioButton();
            radioButton11 = new RadioButton();
            label4 = new Label();
            groupBox4 = new GroupBox();
            radioButton20 = new RadioButton();
            radioButton19 = new RadioButton();
            radioButton18 = new RadioButton();
            radioButton17 = new RadioButton();
            radioButton16 = new RadioButton();
            label5 = new Label();
            groupBox5 = new GroupBox();
            radioButton25 = new RadioButton();
            radioButton24 = new RadioButton();
            radioButton23 = new RadioButton();
            radioButton22 = new RadioButton();
            radioButton21 = new RadioButton();
            buttonBack = new Button();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // submitButton
            // 
            submitButton.Location = new Point(185, 467);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(75, 23);
            submitButton.TabIndex = 0;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 72);
            label1.Name = "label1";
            label1.Size = new Size(298, 15);
            label1.TabIndex = 1;
            label1.Text = "On a scale of 1-5, how much did you enjoy this course?";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton5);
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(85, 90);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 40);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(250, 15);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(31, 19);
            radioButton5.TabIndex = 4;
            radioButton5.TabStop = true;
            radioButton5.Text = "5";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(190, 15);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(31, 19);
            radioButton4.TabIndex = 3;
            radioButton4.TabStop = true;
            radioButton4.Text = "4";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(130, 15);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(31, 19);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "3";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(70, 15);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(31, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(10, 15);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(31, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 152);
            label2.Name = "label2";
            label2.Size = new Size(363, 15);
            label2.TabIndex = 3;
            label2.Text = "On a scale of 1-5, how challenging did you find the course content?";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton10);
            groupBox2.Controls.Add(radioButton9);
            groupBox2.Controls.Add(radioButton8);
            groupBox2.Controls.Add(radioButton7);
            groupBox2.Controls.Add(radioButton6);
            groupBox2.Location = new Point(85, 170);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(300, 40);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            // 
            // radioButton10
            // 
            radioButton10.AutoSize = true;
            radioButton10.Location = new Point(250, 15);
            radioButton10.Name = "radioButton10";
            radioButton10.Size = new Size(31, 19);
            radioButton10.TabIndex = 4;
            radioButton10.TabStop = true;
            radioButton10.Text = "5";
            radioButton10.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            radioButton9.AutoSize = true;
            radioButton9.Location = new Point(190, 15);
            radioButton9.Name = "radioButton9";
            radioButton9.Size = new Size(31, 19);
            radioButton9.TabIndex = 3;
            radioButton9.TabStop = true;
            radioButton9.Text = "4";
            radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            radioButton8.AutoSize = true;
            radioButton8.Location = new Point(130, 15);
            radioButton8.Name = "radioButton8";
            radioButton8.Size = new Size(31, 19);
            radioButton8.TabIndex = 2;
            radioButton8.TabStop = true;
            radioButton8.Text = "3";
            radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.Location = new Point(70, 15);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(31, 19);
            radioButton7.TabIndex = 1;
            radioButton7.TabStop = true;
            radioButton7.Text = "2";
            radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(10, 15);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(31, 19);
            radioButton6.TabIndex = 0;
            radioButton6.TabStop = true;
            radioButton6.Text = "1";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 232);
            label3.Name = "label3";
            label3.Size = new Size(417, 15);
            label3.TabIndex = 5;
            label3.Text = "Do you feel this course has enhanced your understanding of this subject area?";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(radioButton15);
            groupBox3.Controls.Add(radioButton14);
            groupBox3.Controls.Add(radioButton13);
            groupBox3.Controls.Add(radioButton12);
            groupBox3.Controls.Add(radioButton11);
            groupBox3.Location = new Point(85, 250);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(300, 40);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            // 
            // radioButton15
            // 
            radioButton15.AutoSize = true;
            radioButton15.Location = new Point(250, 15);
            radioButton15.Name = "radioButton15";
            radioButton15.Size = new Size(31, 19);
            radioButton15.TabIndex = 4;
            radioButton15.TabStop = true;
            radioButton15.Text = "5";
            radioButton15.UseVisualStyleBackColor = true;
            // 
            // radioButton14
            // 
            radioButton14.AutoSize = true;
            radioButton14.Location = new Point(190, 15);
            radioButton14.Name = "radioButton14";
            radioButton14.Size = new Size(31, 19);
            radioButton14.TabIndex = 3;
            radioButton14.TabStop = true;
            radioButton14.Text = "4";
            radioButton14.UseVisualStyleBackColor = true;
            // 
            // radioButton13
            // 
            radioButton13.AutoSize = true;
            radioButton13.Location = new Point(130, 15);
            radioButton13.Name = "radioButton13";
            radioButton13.Size = new Size(31, 19);
            radioButton13.TabIndex = 2;
            radioButton13.TabStop = true;
            radioButton13.Text = "3";
            radioButton13.UseVisualStyleBackColor = true;
            // 
            // radioButton12
            // 
            radioButton12.AutoSize = true;
            radioButton12.Location = new Point(70, 15);
            radioButton12.Name = "radioButton12";
            radioButton12.Size = new Size(31, 19);
            radioButton12.TabIndex = 1;
            radioButton12.TabStop = true;
            radioButton12.Text = "2";
            radioButton12.UseVisualStyleBackColor = true;
            // 
            // radioButton11
            // 
            radioButton11.AutoSize = true;
            radioButton11.Location = new Point(10, 15);
            radioButton11.Name = "radioButton11";
            radioButton11.Size = new Size(31, 19);
            radioButton11.TabIndex = 0;
            radioButton11.TabStop = true;
            radioButton11.Text = "1";
            radioButton11.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 312);
            label4.Name = "label4";
            label4.Size = new Size(411, 15);
            label4.TabIndex = 7;
            label4.Text = "On a scale of 1-5, how likely are you to take an advanced level of this course?";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(radioButton20);
            groupBox4.Controls.Add(radioButton19);
            groupBox4.Controls.Add(radioButton18);
            groupBox4.Controls.Add(radioButton17);
            groupBox4.Controls.Add(radioButton16);
            groupBox4.Location = new Point(85, 330);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(300, 40);
            groupBox4.TabIndex = 8;
            groupBox4.TabStop = false;
            // 
            // radioButton20
            // 
            radioButton20.AutoSize = true;
            radioButton20.Location = new Point(250, 15);
            radioButton20.Name = "radioButton20";
            radioButton20.Size = new Size(31, 19);
            radioButton20.TabIndex = 4;
            radioButton20.TabStop = true;
            radioButton20.Text = "5";
            radioButton20.UseVisualStyleBackColor = true;
            // 
            // radioButton19
            // 
            radioButton19.AutoSize = true;
            radioButton19.Location = new Point(190, 15);
            radioButton19.Name = "radioButton19";
            radioButton19.Size = new Size(31, 19);
            radioButton19.TabIndex = 3;
            radioButton19.TabStop = true;
            radioButton19.Text = "4";
            radioButton19.UseVisualStyleBackColor = true;
            // 
            // radioButton18
            // 
            radioButton18.AutoSize = true;
            radioButton18.Location = new Point(130, 15);
            radioButton18.Name = "radioButton18";
            radioButton18.Size = new Size(31, 19);
            radioButton18.TabIndex = 2;
            radioButton18.TabStop = true;
            radioButton18.Text = "3";
            radioButton18.UseVisualStyleBackColor = true;
            // 
            // radioButton17
            // 
            radioButton17.AutoSize = true;
            radioButton17.Location = new Point(70, 15);
            radioButton17.Name = "radioButton17";
            radioButton17.Size = new Size(31, 19);
            radioButton17.TabIndex = 1;
            radioButton17.TabStop = true;
            radioButton17.Text = "2";
            radioButton17.UseVisualStyleBackColor = true;
            // 
            // radioButton16
            // 
            radioButton16.AutoSize = true;
            radioButton16.Location = new Point(10, 15);
            radioButton16.Name = "radioButton16";
            radioButton16.Size = new Size(31, 19);
            radioButton16.TabIndex = 0;
            radioButton16.TabStop = true;
            radioButton16.Text = "1";
            radioButton16.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(99, 392);
            label5.Name = "label5";
            label5.Size = new Size(267, 15);
            label5.TabIndex = 9;
            label5.Text = "Is the course relevant to your desired career path?";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(radioButton25);
            groupBox5.Controls.Add(radioButton24);
            groupBox5.Controls.Add(radioButton23);
            groupBox5.Controls.Add(radioButton22);
            groupBox5.Controls.Add(radioButton21);
            groupBox5.Location = new Point(85, 410);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(300, 40);
            groupBox5.TabIndex = 10;
            groupBox5.TabStop = false;
            // 
            // radioButton25
            // 
            radioButton25.AutoSize = true;
            radioButton25.Location = new Point(250, 15);
            radioButton25.Name = "radioButton25";
            radioButton25.Size = new Size(31, 19);
            radioButton25.TabIndex = 4;
            radioButton25.TabStop = true;
            radioButton25.Text = "5";
            radioButton25.UseVisualStyleBackColor = true;
            // 
            // radioButton24
            // 
            radioButton24.AutoSize = true;
            radioButton24.Location = new Point(190, 15);
            radioButton24.Name = "radioButton24";
            radioButton24.Size = new Size(31, 19);
            radioButton24.TabIndex = 3;
            radioButton24.TabStop = true;
            radioButton24.Text = "4";
            radioButton24.UseVisualStyleBackColor = true;
            // 
            // radioButton23
            // 
            radioButton23.AutoSize = true;
            radioButton23.Location = new Point(130, 15);
            radioButton23.Name = "radioButton23";
            radioButton23.Size = new Size(31, 19);
            radioButton23.TabIndex = 2;
            radioButton23.TabStop = true;
            radioButton23.Text = "3";
            radioButton23.UseVisualStyleBackColor = true;
            // 
            // radioButton22
            // 
            radioButton22.AutoSize = true;
            radioButton22.Location = new Point(70, 15);
            radioButton22.Name = "radioButton22";
            radioButton22.Size = new Size(31, 19);
            radioButton22.TabIndex = 1;
            radioButton22.TabStop = true;
            radioButton22.Text = "2";
            radioButton22.UseVisualStyleBackColor = true;
            // 
            // radioButton21
            // 
            radioButton21.AutoSize = true;
            radioButton21.Location = new Point(10, 15);
            radioButton21.Name = "radioButton21";
            radioButton21.Size = new Size(31, 19);
            radioButton21.TabIndex = 0;
            radioButton21.TabStop = true;
            radioButton21.Text = "1";
            radioButton21.UseVisualStyleBackColor = true;
            // 
            // buttonBack
            // 
            buttonBack.BackColor = Color.FromArgb(66, 139, 202);
            buttonBack.FlatStyle = FlatStyle.Popup;
            buttonBack.ForeColor = Color.White;
            buttonBack.Location = new Point(12, 12);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(80, 30);
            buttonBack.TabIndex = 11;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += backButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(24, 105);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 12;
            label6.Text = "Not at all";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(391, 105);
            label7.Name = "label7";
            label7.Size = new Size(66, 15);
            label7.TabIndex = 13;
            label7.Text = "Very much";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(24, 187);
            label8.Name = "label8";
            label8.Size = new Size(53, 15);
            label8.TabIndex = 14;
            label8.Text = "Difficult";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(391, 189);
            label9.Name = "label9";
            label9.Size = new Size(30, 15);
            label9.TabIndex = 15;
            label9.Text = "Easy";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(18, 267);
            label10.Name = "label10";
            label10.Size = new Size(57, 15);
            label10.TabIndex = 16;
            label10.Text = "Not at all";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(391, 267);
            label11.Name = "label11";
            label11.Size = new Size(66, 15);
            label11.TabIndex = 17;
            label11.Text = "Very much";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(22, 345);
            label12.Name = "label12";
            label12.Size = new Size(60, 15);
            label12.TabIndex = 18;
            label12.Text = "Not likely";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(391, 347);
            label13.Name = "label13";
            label13.Size = new Size(64, 15);
            label13.TabIndex = 19;
            label13.Text = "Very likely";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(18, 427);
            label14.Name = "label14";
            label14.Size = new Size(57, 15);
            label14.TabIndex = 20;
            label14.Text = "Not at all";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(391, 427);
            label15.Name = "label15";
            label15.Size = new Size(66, 15);
            label15.TabIndex = 21;
            label15.Text = "Very much";
            // 
            // Questionnaire
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(485, 502);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(buttonBack);
            Controls.Add(groupBox5);
            Controls.Add(label5);
            Controls.Add(groupBox4);
            Controls.Add(label4);
            Controls.Add(groupBox3);
            Controls.Add(label3);
            Controls.Add(groupBox2);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(submitButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Questionnaire";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Questionnaire";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Button buttonBack;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
    }
}
