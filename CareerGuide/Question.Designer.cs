namespace CareerGuide
{
    partial class Question
    {
        private Label questionLabel;
        private RadioButton choiceARadioButton;
        private RadioButton choiceBRadioButton;
        private RadioButton choiceCRadioButton;
        private Button submitButton;

        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Question));
            questionLabel = new Label();
            choiceARadioButton = new RadioButton();
            choiceBRadioButton = new RadioButton();
            choiceCRadioButton = new RadioButton();
            submitButton = new Button();
            SuspendLayout();
            // 
            // questionLabel
            // 
            questionLabel.AutoSize = true;
            questionLabel.Location = new Point(20, 20);
            questionLabel.Name = "questionLabel";
            questionLabel.Size = new Size(0, 15);
            questionLabel.TabIndex = 0;
            // 
            // choiceARadioButton
            // 
            choiceARadioButton.AutoSize = true;
            choiceARadioButton.Location = new Point(20, 60);
            choiceARadioButton.Name = "choiceARadioButton";
            choiceARadioButton.Size = new Size(73, 19);
            choiceARadioButton.TabIndex = 1;
            choiceARadioButton.TabStop = true;
            choiceARadioButton.Text = "Choice A";
            // 
            // choiceBRadioButton
            // 
            choiceBRadioButton.AutoSize = true;
            choiceBRadioButton.Location = new Point(20, 90);
            choiceBRadioButton.Name = "choiceBRadioButton";
            choiceBRadioButton.Size = new Size(72, 19);
            choiceBRadioButton.TabIndex = 2;
            choiceBRadioButton.TabStop = true;
            choiceBRadioButton.Text = "Choice B";
            // 
            // choiceCRadioButton
            // 
            choiceCRadioButton.AutoSize = true;
            choiceCRadioButton.Location = new Point(20, 120);
            choiceCRadioButton.Name = "choiceCRadioButton";
            choiceCRadioButton.Size = new Size(73, 19);
            choiceCRadioButton.TabIndex = 3;
            choiceCRadioButton.TabStop = true;
            choiceCRadioButton.Text = "Choice C";
            // 
            // submitButton
            // 
            submitButton.Location = new Point(210, 164);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(80, 30);
            submitButton.TabIndex = 4;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // Question
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 211);
            Controls.Add(submitButton);
            Controls.Add(choiceCRadioButton);
            Controls.Add(choiceBRadioButton);
            Controls.Add(choiceARadioButton);
            Controls.Add(questionLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Question";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Question";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
