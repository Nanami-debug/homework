using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCF_HomeWork_1._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float result = 0;
            string input = textBox2.Text;
            string[] part = input.Split(' ');
            float a = float.Parse(part[0]);
            float b = float.Parse(part[2]);
            char op = char.Parse(part[1]);
            if (op == '+')
            {
                result = a + b;
            }
            else if (op == '-')
            {
                result = a - b;
            }
            else if (op == '*')
            {
                result = a * b;
            }
            else
            {
                result = a / b;
            }
            MessageBox.Show($"答案是{result}");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
