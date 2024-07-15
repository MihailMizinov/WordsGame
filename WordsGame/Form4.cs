using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SQLite;
using Microsoft.Data.Sqlite;

namespace WordsGame
{
    public partial class Form4 : Form
    {
        private EventArgs e;
        private static int level;
        private List<string> words1 = new List<string>();
        private static string word;
        private static bool IsReal;
        private static bool WasLater;
        private static int[] levelCountWords = new int[6];
        public static int length;
        public static string str_local_score;
        private static string nickname;
        public Form4(int CurrentLevel, string nicknameInForm)
        {
            level = CurrentLevel;
            nickname = nicknameInForm;

            InitializeComponent();
            switch (level)
            {
                case 1:
                    levelCountWords[1] = 11;
                    labelU.Text = "Л";
                    labelUR.Text = "Е";
                    labelDR.Text = "С";
                    labelUL.Text = "О";
                    labelDL.Text = "В";
                    break;
                case 2:
                    levelCountWords[2] = 15;
                    labelU.Text = "Р";
                    labelUR.Text = "У";
                    labelDR.Text = "А";
                    labelUL.Text = "Н";
                    labelDL.Text = "К";
                    break;
                case 3:
                    levelCountWords[3] = 9;
                    labelU.Text = "И";
                    labelUR.Text = "Н";
                    labelDR.Text = "П";
                    labelUL.Text = "Е";
                    labelDL.Text = "Л";
                    break;
                case 4:
                    levelCountWords[4] = 10;
                    labelU.Text = "З";
                    labelUR.Text = "Е";
                    labelDR.Text = "Б";
                    labelUL.Text = "Р";
                    labelDL.Text = "А";
                    break;
                case 5:
                    levelCountWords[5] = 9;
                    labelU.Text = "Л";
                    labelUR.Text = "Е";
                    labelDR.Text = "П";
                    labelUL.Text = "К";
                    labelDL.Text = "А";
                    break;
            }
            labelScore.Text = Convert.ToString(levelCountWords[level]);
            try
            {
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке данных: " + ex.Message);
            }
        }
        private void LoadData()
        {
            string connectionString = "Data Source=C:\\SQLite\\Words.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Score WHERE Level = @level";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@level", level);

                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
        }
        private void ToButton(string tx)
        {
            if (label1.Text == "")
            { label1.Text = tx; }
            else if (label2.Text == "")
            { label2.Text = tx; }
            else if (label3.Text == "")
            { label3.Text = tx; }
            else if (label4.Text == "")
            { label4.Text = tx; }
            else if (label5.Text == "")
            { label5.Text = tx; }
            else if (label6.Text == "")
            { label6.Text = tx; }
            else if (label7.Text == "")
            { label7.Text = tx; }
            else if (label8.Text == "")
            { label8.Text = tx; }
            else if (label9.Text == "")
            { label9.Text = tx; }
            else if (label10.Text == "")
            { label10.Text = tx; }
            else if (label11.Text == "")
            { label11.Text = tx; }
        }
        private void labelClear_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
            label10.Text = "";
            label11.Text = "";
        }
        private void HowLong()
        {
            if (label1.Text != "")
            {
                length++;
                word = word + label1.Text;

            }
            if (label2.Text != "")
            {
                length++;
                word = word + label2.Text;
            }
            if (label3.Text != "")
            {
                length++;
                word = word + label3.Text;
            }
            if (label4.Text != "")
            {
                length++;
                word = word + label4.Text;
            }
            if (label5.Text != "")
            {
                length++;
                word = word + label5.Text;
            }
            if (label6.Text != "")
            {
                length++;
                word = word + label6.Text;
            }
            if (label7.Text != "")
            {
                length++;
                word = word + label7.Text;
            }
            if (label8.Text != "")
            {
                length++;
                word = word + label8.Text;
            }
            if (label9.Text != "")
            {
                length++;
                word = word + label9.Text;
            }
            if (label10.Text != "")
            {
                length++;
                word = word + label10.Text;
            }
            if (label11.Text != "")
            {
                length++;
                word = word + label11.Text;
            }
        }
        private void labelApply_Click(object sender, EventArgs e)
        {
            if (label1.Text != "")
            {
                HowLong();

                IsWordReal(word);
                string connectionString = "Data Source=C:\\SQLite\\Words.db;Version=3;";
                if (IsReal)
                {
                    str_local_score = length.ToString();

                    using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                    {
                        connection.Open();

                        // Проверка наличия никнейма в базе данных
                        string queryCheck = "SELECT COUNT(*) FROM Score WHERE Nickname = @nickname AND Level = @level";
                        using (SQLiteCommand commandCheck = new SQLiteCommand(queryCheck, connection))
                        {
                            commandCheck.Parameters.AddWithValue("@nickname", nickname);
                            commandCheck.Parameters.AddWithValue("@level", level);
                            int existingRecords = Convert.ToInt32(commandCheck.ExecuteScalar());

                            if (existingRecords > 0)
                            {
                                // Если никнейм уже существует, увеличиваем значение Score
                                string queryUpdate = "UPDATE Score SET Score = Score + @length WHERE Nickname = @nickname AND Level = @level";
                                using (SQLiteCommand commandUpdate = new SQLiteCommand(queryUpdate, connection))
                                {
                                    commandUpdate.Parameters.AddWithValue("@nickname", nickname);
                                    commandUpdate.Parameters.AddWithValue("@length", length);
                                    commandUpdate.Parameters.AddWithValue("@level", level);
                                    commandUpdate.ExecuteNonQuery(); // Обновление записи
                                }
                                labelAdding.Visible = true;
                                labelAdding.Text = "К счету добавлено " + length + " баллов!";
                                levelCountWords[level]--;
                                labelScore.Text = Convert.ToString(levelCountWords[level]);
                                if (levelCountWords[level] == 0)
                                {
                                    label9.Visible = true;
                                    label9.BackColor = Color.White;
                                    label9.Text = "Вы прошли " + Convert.ToString(level) + " уровень!";
                                }
                            }
                            else
                            {
                                string queryInsert = "INSERT INTO Score (Nickname, Level, Score) VALUES (@nickname, @level, @length)";
                                using (SQLiteCommand commandInsert = new SQLiteCommand(queryInsert, connection))
                                {
                                    commandInsert.Parameters.AddWithValue("@nickname", nickname);
                                    commandInsert.Parameters.AddWithValue("@level", level);
                                    commandInsert.Parameters.AddWithValue("@length", length);
                                    commandInsert.ExecuteNonQuery();
                                }
                                labelAdding.Visible = true;
                                labelAdding.Text = "К счету добавлено " + length + " баллов!";
                                levelCountWords[level]--;
                                labelScore.Text = Convert.ToString(levelCountWords[level]);
                            }
                        }
                    }
                }
                else
                {
                    if (WasLater)
                    {
                        labelIfNotRealWord.Visible = true;
                        labelIfNotRealWord.Text = "Вы уже угадали это слово!";
                        WasLater = false;
                    }
                    else
                    {
                        labelIfNotRealWord.Visible = true;
                        labelIfNotRealWord.Text = "Такого слова не существует!";
                    }
                }
                LoadData();
                word = "";
                length = 0;
            }

            labelClear_Click(sender, e);
        }


        private void labelU_Click(object sender, EventArgs e)
        {
            labelAdding.Visible = false;
            labelIfNotRealWord.Visible = false;
            switch (level)
            {
                case 1:
                    ToButton("Л");
                    break;
                case 2:
                    ToButton("Р");
                    break;
                case 3:
                    ToButton("И");
                    break;
                case 4:
                    ToButton("З");
                    break;
                case 5:
                    ToButton("Л");
                    break;
            }
        }

        private void labelUR_Click(object sender, EventArgs e)
        {
            labelAdding.Visible = false;
            labelIfNotRealWord.Visible = false;
            switch (level)
            {
                case 1:
                    ToButton("Е");
                    break;
                case 2:
                    ToButton("У");
                    break;
                case 3:
                    ToButton("Н");
                    break;
                case 4:
                    ToButton("Е");
                    break;
                case 5:
                    ToButton("Е");
                    break;
            }
        }

        private void labelUL_Click(object sender, EventArgs e)
        {
            labelAdding.Visible = false;
            labelIfNotRealWord.Visible = false;
            switch (level)
            {
                case 1:
                    ToButton("О");
                    break;
                case 2:
                    ToButton("Н");
                    break;
                case 3:
                    ToButton("Е");
                    break;
                case 4:
                    ToButton("Р");
                    break;
                case 5:
                    ToButton("К");
                    break;
            }
        }

        private void labelDL_Click(object sender, EventArgs e)
        {
            labelAdding.Visible = false;
            labelIfNotRealWord.Visible = false;
            switch (level)
            {
                case 1:
                    ToButton("В");
                    break;
                case 2:
                    ToButton("К");
                    break;
                case 3:
                    ToButton("Л");
                    break;
                case 4:
                    ToButton("А");
                    break;
                case 5:
                    ToButton("А");
                    break;

            }
        }
        private void labelDR_Click(object sender, EventArgs e)
        {
            labelAdding.Visible = false;
            labelIfNotRealWord.Visible = false;
            switch (level)
            {
                case 1:
                    ToButton("С");
                    break;
                case 2:
                    ToButton("А");
                    break;
                case 3:
                    ToButton("П");
                    break;
                case 4:
                    ToButton("Б");
                    break;
                case 5:
                    ToButton("П");
                    break;
            }
        }
        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            Form form3 = new Form3(nickname);
            this.Hide();
            form3.ShowDialog();
            this.Dispose();
            this.Close();
        }
        private void IsWordReal(string word)
        {
            string[] words;
            switch (level)
            {
                case 1:
                    words = new string[] { "ВЕСЛО", "ВОЛОС", "СЛОВО", "ОЛОВО", "СЕЛО", "СОЛО", "ВЕС", "СЕВ", "ЛОВ", "ЛЕВ", "ЛЕС" };
                    IsReal = words.Contains(word);
                    if (words1.Contains(word))
                    {
                        IsReal = false;
                        WasLater = true;
                    }
                    else { words1.Add(word); }
                    break;

                case 2:
                    words = new string[] { "РУКА", "РУНА", "УРАН", "НУАР", "РАК", "АКР", "КУРА", "УРНА", "РАКУН", "АРКАН", "РАНА", "АУРА", "НАУКА", "КУКАН", "КРАН" };
                    IsReal = words.Contains(word);
                    if (words1.Contains(word))
                    {
                        IsReal = false;
                        WasLater = true;
                    }
                    else { words1.Add(word); }
                    break;
                case 3:
                    words = new string[] { "ПЕПЕЛ", "ПЕНИЕ", "ПЛЕН", "ПЕННИ", "ИЛ", "ПИ", "ПЛЕНЕНИЕ", "ЛЕПЛЕНИЕ", "ЛЕН" };
                    IsReal = words.Contains(word);
                    if (words1.Contains(word))
                    {
                        IsReal = false;
                        WasLater = true;
                    }
                    else { words1.Add(word); }
                    break;
                case 4:
                    words = new string[] { "ЗЕБРА", "БАЗАР", "РАЗРЕЗ", "БАЗА", "БЕЗЕ", "БАР", "РАБ", "АРАБ", "ЗАРЕЗ", "ЗАРАЗА" };
                    IsReal = words.Contains(word);
                    if (words1.Contains(word))
                    {
                        IsReal = false;
                        WasLater = true;
                    }
                    else { words1.Add(word); }
                    break;
                case 5:
                    words = new string[] { "КЕПКА", "КАПЕЛЛА", "КАЛЕКА", "ПАПКА", "ЛАПА", "ПАЛКА", "ПЕПЕЛ", "ЛАК", "ЛЕПКА" };
                    IsReal = words.Contains(word);
                    if (words1.Contains(word))
                    {
                        IsReal = false;
                        WasLater = true;
                    }
                    else { words1.Add(word); }
                    break;
            }
        }

    }
}
