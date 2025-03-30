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
using ORDER_SERVICE;

namespace FORM5
{
    public partial class Form5 : Form
    {
        public Order_Service o;
        public Form5(Order_Service service)
        {
            InitializeComponent();
            this.o = service;
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            int id = int.Parse(textBox2.Text);
            if (o.id_and_name(id, name))
            {
                foreach (Order _o in o.orders)
                {
                    if (_o.id == id)
                    {
                        dataGridView1.DataSource = _o.datail.Goods;
                        dataGridView1.ReadOnly = false;
                        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                        dataGridView1.Refresh();
                        break;
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 设置 DialogResult
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
