using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ORDER;
using ORDER_DATAIL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FORM2
{
    public partial class Form2 : Form
    {

        public Order order;
        public string message = "";
        public Form2(int id)
        {
            InitializeComponent();
            order = new Order(id+1, "a");
            label6.DataBindings.Add("Text", this, message);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 设置 DialogResult
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            order.name = textBox1.Text;
            order.datail.Goods.Add(new Node(textBox3.Text, int.Parse(textBox4.Text),
                int.Parse(textBox5.Text)));
            message = $"添加{textBox3}成功";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            label6.DataBindings.Add("Text", this, message);
        }
        private void label6_Click_1(object sender, EventArgs e)
        {
            label6.DataBindings.Add("Text", this, message);
        }
    }
}
