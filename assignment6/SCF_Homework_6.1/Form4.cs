using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ORDER_SERVICE;

namespace FORM4
{
    public partial class Form4 : Form
    {
        public Order_Service o;
        public Form4(Order_Service o)
        {

            InitializeComponent();
            this.o = o;
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text);
            string name = textBox2.Text;
            if (o.id_and_name(id, name))
            {
                o.Remove_Order(id);
            }
            else MessageBox.Show("您的单号和名字不匹配，请重新输入");
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 设置 DialogResult
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
