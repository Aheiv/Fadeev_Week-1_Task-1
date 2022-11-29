using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лаб1_2УП_WinForms
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value < 10 || numericUpDown1.Value > 99)
            {
                MessageBox.Show("Некорректный ввод данных");
                return;
            }
            int a = int.Parse(numericUpDown1.Text);
            int n = (a / 10 + a % 10);
            textBox1.Text = n.ToString();
            if (n % 2 != 0)
                textBox2.Text = "Да";
            else textBox2.Text = "Нет";
        }
    }
}
