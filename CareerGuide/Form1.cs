using System.Configuration;
using System.Data.SQLite;

namespace CareerGuide
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            string connectionString = ConfigurationManager.ConnectionStrings["CareerGuide"].ConnectionString;

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT id FROM student WHERE username = @username AND password = @password";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    var result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        int userId = Convert.ToInt32(result);
                        this.Hide();
                        new Home(username, userId).ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        // Handle incorrect username or password
                        MessageBox.Show("Incorrect username or password!", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                conn.Close();
            }
        }


    }
}