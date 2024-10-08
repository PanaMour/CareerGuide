namespace CareerGuide
{
    partial class AuditoryContent
    {
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuditoryContent));
            webBrowserYouTube = new WebBrowser();
            btnNext = new Button();
            btnPrev = new Button();
            axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
            SuspendLayout();
            // 
            // webBrowserYouTube
            // 
            webBrowserYouTube.Location = new Point(14, 14);
            webBrowserYouTube.Margin = new Padding(4, 3, 4, 3);
            webBrowserYouTube.MinimumSize = new Size(23, 23);
            webBrowserYouTube.Name = "webBrowserYouTube";
            webBrowserYouTube.Size = new Size(700, 404);
            webBrowserYouTube.TabIndex = 0;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(626, 438);
            btnNext.Margin = new Padding(4, 3, 4, 3);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(88, 27);
            btnNext.TabIndex = 2;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnPrev
            // 
            btnPrev.Location = new Point(14, 438);
            btnPrev.Margin = new Padding(4, 3, 4, 3);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(88, 27);
            btnPrev.TabIndex = 1;
            btnPrev.Text = "Previous";
            btnPrev.UseVisualStyleBackColor = true;
            btnPrev.Click += btnPrev_Click;
            // 
            // axWindowsMediaPlayer1
            // 
            axWindowsMediaPlayer1.Enabled = true;
            axWindowsMediaPlayer1.Location = new Point(14, 14);
            axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            axWindowsMediaPlayer1.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayer1.OcxState");
            axWindowsMediaPlayer1.Size = new Size(700, 404);
            axWindowsMediaPlayer1.TabIndex = 3;
            // 
            // AuditoryContent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(728, 486);
            Controls.Add(axWindowsMediaPlayer1);
            Controls.Add(btnNext);
            Controls.Add(btnPrev);
            Controls.Add(webBrowserYouTube);
            Name = "AuditoryContent";
            Text = "Auditory Content Viewer";
            Load += AuditoryContent_Load;
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowserYouTube;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}
