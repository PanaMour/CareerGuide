namespace CareerGuide
{
    partial class Content
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;

        // Declare a PdfViewer control
        private PdfiumViewer.PdfViewer pdfViewer;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Content));
            pdfViewer = new PdfiumViewer.PdfViewer();
            SuspendLayout();
            // 
            // pdfViewer
            // 
            pdfViewer.Dock = DockStyle.Fill;
            pdfViewer.Location = new Point(0, 0);
            pdfViewer.Margin = new Padding(4, 3, 4, 3);
            pdfViewer.Name = "pdfViewer";
            pdfViewer.Size = new Size(800, 450);
            pdfViewer.TabIndex = 0;
            // Next Button
            this.btnNext = new System.Windows.Forms.Button();
            this.btnNext.Location = new System.Drawing.Point(120, 400);  // Adjust the coordinates
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            this.btnNext.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;  // Set the Anchor property

            // Previous Button
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnPrev.Location = new System.Drawing.Point(40, 400);  // Adjust the coordinates
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 23);
            this.btnPrev.TabIndex = 2;
            this.btnPrev.Text = "Previous";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            this.btnPrev.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;  // Set the Anchor property

            // Add buttons to the form
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            // 
            // Content
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pdfViewer);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Content";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Content";
            Load += Content_Load;
            ResumeLayout(false);
        }

        #endregion
    }
}
