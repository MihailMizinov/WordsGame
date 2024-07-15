using System.Data.SQLite;

namespace WordsGame
{
    public partial class Form1 : Form
    {
        private static string? login;
        private static string? password;
        private static string? nickname;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form2 = new Form2();
            this.Hide();
            form2.ShowDialog();
            this.Dispose();
            this.Close();
        }

        private void GetNickname()
        {
            string connectionString = "Data Source=C:\\SQLite\\Words.db;Version=3;";
            string query = "SELECT Nickname FROM Users_Data WHERE Login = @login AND Password = @password";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@login", login);
                    command.Parameters.AddWithValue("@password", password);
                    connection.Open();

                    SQLiteDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        nickname = reader["Nickname"].ToString();
                    }

                    reader.Close();
                    connection.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                //enter
                string connectionString = "Data Source=C:\\SQLite\\Words.db;Version=3;";
                login = textBox1.Text;
                password = textBox2.Text;
                string query = "SELECT COUNT(*) FROM Users_Data WHERE Login = @login AND Password = @password";
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@login", login);
                        command.Parameters.AddWithValue("@password", password);
                        connection.Open();

                        int count = Convert.ToInt32(command.ExecuteScalar());

                        connection.Close();
                        GetNickname();
                        if (count > 0)
                        {
                            Form form3 = new Form3(nickname);
                            this.Hide();
                            form3.ShowDialog();
                            this.Dispose();
                            this.Close();

                            label10.Text = "";
                        }
                        else
                        {
                            label10.Text = "Error in login or password";
                        }
                    }
                }
            }
            else
            {
                label10.Text = "Some of the fields are empty";
            }
        }
    }
}
