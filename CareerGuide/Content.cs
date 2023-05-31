using System;
using System.Windows.Forms;
using PdfiumViewer;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;

namespace CareerGuide
{
    public partial class Content : Form
    {
        int courseId = 0;
        // List of PDF file paths
        private List<string> GetPdfFiles(int courseId)
        {
            List<string> pdfFiles = new List<string>();

            string connectionString = ConfigurationManager.ConnectionStrings["CareerGuide"].ConnectionString;
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT content_url FROM content WHERE course_id = @courseId";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@courseId", courseId);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string contentUrl = reader.GetString(0);
                            pdfFiles.Add(contentUrl);
                        }
                    }
                }

                conn.Close();
            }

            return pdfFiles;
        }


        private int currentIndex = 0;

        public Content()
        {
            InitializeComponent();
        }
        public Content(int arg1)
        {
            InitializeComponent();
            courseId = arg1;
        }
        private void Content_Load(object sender, EventArgs e)
        {
            LoadPdf(GetPdfFiles(courseId)[currentIndex]);
        }

        private void LoadPdf(string path)
        {
            try
            {
                var pdfDocument = PdfDocument.Load(path);
                pdfViewer.Document = pdfDocument;
            }
            catch (Exception ex)
            {
                // Handle exception if the PDF file could not be loaded
                MessageBox.Show("The PDF file could not be loaded. Error: " + ex.Message);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            currentIndex = (currentIndex + 1) % GetPdfFiles(courseId).Count;  // Cycle to the start when reaching the end
            LoadPdf(GetPdfFiles(courseId)[currentIndex]);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            currentIndex = (currentIndex - 1 + GetPdfFiles(courseId).Count) % GetPdfFiles(courseId).Count;  // Cycle to the end when reaching the start
            LoadPdf(GetPdfFiles(courseId)[currentIndex]);
        }
    }
}
