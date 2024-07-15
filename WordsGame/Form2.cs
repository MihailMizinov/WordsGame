using Microsoft.VisualBasic.Logging;
using System;
using System.Data.SQLite;

namespace WordsGame
{
    public partial class Form2 : Form
    {
        private static string login;
        private static string password;
        private static string nickname;
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                string login = textBox1.Text;
                string password = textBox3.Text;
                string nickname = textBox2.Text;
                string connectionString = "Data Source=C:\\SQLite\\Words.db;Version=3;";

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO Users_Data (Login, Password, Nickname) VALUES (@login, @password, @nickname)";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@login", login);
                        command.Parameters.AddWithValue("@password", password);
                        command.Parameters.AddWithValue("@nickname", nickname);

                        command.ExecuteNonQuery();
                    }
                }

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";

                Form form1 = new Form1();
                this.Hide();
                form1.ShowDialog();
                this.Dispose();
                this.Close();

                label1.Text = "";
            }
            else
            {
                label1.Text = "Some of the fields are empty";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
            this.Dispose();
            this.Close();
        }
    }
}
