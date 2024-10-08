using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Windows.Forms;

namespace CareerGuide
{
    public partial class AuditoryContent : Form
    {
        private List<string> GetVideoFiles(int courseId)
        {
            List<string> videoFiles = new List<string>();

            string connectionString = ConfigurationManager.ConnectionStrings["CareerGuide"].ConnectionString;
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT content_video FROM content WHERE course_id = @courseId";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@courseId", courseId);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string contentVideo = reader.GetString(0);
                            videoFiles.Add(contentVideo);
                        }
                    }
                }

                conn.Close();
            }

            return videoFiles;
        }

        private int currentIndex = 0;

        public AuditoryContent()
        {
            InitializeComponent();
        }

        private void AuditoryContent_Load(object sender, EventArgs e)
        {
            List<string> videoFiles = GetVideoFiles(StudentInformation.CourseId);
            if (videoFiles.Count > 0)
            {
                LoadVideo(videoFiles[currentIndex]);
            }
            else
            {
                MessageBox.Show("No videos available for this course.", "No Content", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LoadVideo(string videoUrl)
        {
            try
            {
                axWindowsMediaPlayer1.URL = videoUrl;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("The video could not be loaded. Error: " + ex.Message);
            }
        }



        private void btnNext_Click(object sender, EventArgs e)
        {
            List<string> videoFiles = GetVideoFiles(StudentInformation.CourseId);
            if (videoFiles.Count > 0)
            {
                currentIndex = (currentIndex + 1) % videoFiles.Count;
                LoadVideo(videoFiles[currentIndex]);
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            List<string> videoFiles = GetVideoFiles(StudentInformation.CourseId);
            if (videoFiles.Count > 0)
            {
                currentIndex = (currentIndex - 1 + videoFiles.Count) % videoFiles.Count;
                LoadVideo(videoFiles[currentIndex]);
            }
        }
    }
}
