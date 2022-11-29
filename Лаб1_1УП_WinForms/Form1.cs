using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лаб1_1УП_WinForms
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
            if (numericUpDown1.Value <= 0)
            {
                MessageBox.Show("Некорректный ввод данных!");
                return;
            }
            double v;
            v = double.Parse(numericUpDown1.Text);
            double a = Math.Pow(v, 1/3.0);
            textBox2.Text = a.ToString();
        }
    }
}
