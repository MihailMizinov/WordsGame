using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordsGame
{
    public partial class Form3 : Form
    {
        private static string nicknameStatic;
        public Form3(string nickname)
        {
            nicknameStatic = nickname;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form form4 = new Form4(1, nicknameStatic);
            this.Hide();
            form4.ShowDialog();
            this.Dispose();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form form4 = new Form4(2, nicknameStatic);
            this.Hide();
            form4.ShowDialog();
            this.Dispose();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form form4 = new Form4(3, nicknameStatic);
            this.Hide();
            form4.ShowDialog();
            this.Dispose();
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form form4 = new Form4(4, nicknameStatic);
            this.Hide();
            form4.ShowDialog();
            this.Dispose();
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form form4 = new Form4(5, nicknameStatic);
            this.Hide();
            form4.ShowDialog();
            this.Dispose();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Form form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
            this.Dispose();
            this.Close();
        }
    }
}
