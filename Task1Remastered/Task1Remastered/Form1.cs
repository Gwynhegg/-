using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1Remastered
{
    public partial class Form1 : Form
    {
        string name, surname;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!="")
            {
                name = textBox1.Text;
                button1.Visible = false;
                button2.Visible = true;
                textBox1.Text = "";
            } else
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Visible = false;
            button1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                surname = textBox1.Text;
                textBox1.Text = "";
                DialogResult result = MessageBox.Show("О, да вы же " + name + " " + surname, "Поздравляем!", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK);
            }
        }
    }
}
