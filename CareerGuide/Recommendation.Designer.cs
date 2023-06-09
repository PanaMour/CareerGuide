namespace CareerGuide
{
    partial class Recommendation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private Label labelTitle;
        private Label labelDescription1;
        private Label labelDescription2;
        private Label labelRecommendedCareer;

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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Recommendation));
            labelTitle = new Label();
            labelDescription1 = new Label();
            labelDescription2 = new Label();
            labelRecommendedCareer = new Label();
            buttonBack = new Button();
            labelPostgraduateProgram = new Label();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.BackColor = Color.Transparent;
            labelTitle.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.ForeColor = Color.FromArgb(64, 64, 64);
            labelTitle.Location = new Point(168, 19);
            labelTitle.Margin = new Padding(4, 0, 4, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(356, 37);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Possible Career Paths";
            // 
            // labelDescription1
            // 
            labelDescription1.AutoSize = true;
            labelDescription1.BackColor = Color.Transparent;
            labelDescription1.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelDescription1.ForeColor = Color.FromArgb(64, 64, 64);
            labelDescription1.Location = new Point(23, 201);
            labelDescription1.Margin = new Padding(4, 0, 4, 0);
            labelDescription1.Name = "labelDescription1";
            labelDescription1.Size = new Size(608, 22);
            labelDescription1.TabIndex = 1;
            labelDescription1.Text = "Recommended postgraduate program based on performance analysis:";
            // 
            // labelDescription2
            // 
            labelDescription2.AutoSize = true;
            labelDescription2.BackColor = Color.Transparent;
            labelDescription2.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelDescription2.ForeColor = Color.FromArgb(64, 64, 64);
            labelDescription2.Location = new Point(23, 82);
            labelDescription2.Margin = new Padding(4, 0, 4, 0);
            labelDescription2.Name = "labelDescription2";
            labelDescription2.Size = new Size(242, 22);
            labelDescription2.TabIndex = 2;
            labelDescription2.Text = "We recommend the career:";
            // 
            // labelRecommendedCareer
            // 
            labelRecommendedCareer.AutoSize = true;
            labelRecommendedCareer.BackColor = Color.Transparent;
            labelRecommendedCareer.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point);
            labelRecommendedCareer.ForeColor = Color.FromArgb(0, 122, 204);
            labelRecommendedCareer.Location = new Point(67, 124);
            labelRecommendedCareer.Margin = new Padding(4, 0, 4, 0);
            labelRecommendedCareer.Name = "labelRecommendedCareer";
            labelRecommendedCareer.Size = new Size(523, 56);
            labelRecommendedCareer.TabIndex = 3;
            labelRecommendedCareer.Text = "Systems Programmer";
            // 
            // buttonBack
            // 
            buttonBack.BackColor = Color.FromArgb(66, 139, 202);
            buttonBack.FlatStyle = FlatStyle.Popup;
            buttonBack.ForeColor = Color.White;
            buttonBack.Location = new Point(23, 26);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(80, 30);
            buttonBack.TabIndex = 12;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += backButton_Click;
            // 
            // labelPostgraduateProgram
            // 
            labelPostgraduateProgram.AutoSize = true;
            labelPostgraduateProgram.BackColor = Color.Transparent;
            labelPostgraduateProgram.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelPostgraduateProgram.ForeColor = Color.FromArgb(64, 64, 64);
            labelPostgraduateProgram.Location = new Point(23, 240);
            labelPostgraduateProgram.Margin = new Padding(4, 0, 4, 0);
            labelPostgraduateProgram.Name = "labelPostgraduateProgram";
            labelPostgraduateProgram.Size = new Size(567, 18);
            labelPostgraduateProgram.TabIndex = 13;
            labelPostgraduateProgram.Text = "Master's in Software Engineering with a focus on Software Engineering Practices";
            // 
            // Recommendation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(650, 281);
            Controls.Add(labelPostgraduateProgram);
            Controls.Add(buttonBack);
            Controls.Add(labelTitle);
            Controls.Add(labelDescription1);
            Controls.Add(labelDescription2);
            Controls.Add(labelRecommendedCareer);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "Recommendation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Recommendation";
            ResumeLayout(false);
            PerformLayout();
        }

        private Button buttonBack;
        private Label labelPostgraduateProgram;
    }
}
