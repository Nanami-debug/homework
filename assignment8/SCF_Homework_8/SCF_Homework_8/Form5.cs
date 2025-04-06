using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using ORDER;
using ORDER_SERVICE;
using Myd;
using Mysqlx.Crud;
using MySql.Data.MySqlClient;
using ORDER_DATAIL;

namespace FORM5
{
    public partial class Form5 : Form
    {
        public Order_Service o;
        public Form5(Order_Service service)
        {
            InitializeComponent();
            this.o = service;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
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
                using (var context = new MyDB())
                {
                    var order = context.Orders
                            .Include(o => o.datail) // 加载Order_Detail
                            .ThenInclude(d => d.Goods)// 加载Node
                            .FirstOrDefault(o=>o.id==id);
                    dataGridView1.DataSource=order.datail.Goods;
                    dataGridView1.ReadOnly = false;

                    dataGridView1.Columns["Order_DetailId"].Visible = false;
                    dataGridView1.Columns["Order_Detail"].Visible = false;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                    dataGridView1.Refresh();
                }
            }
        }
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // 确保不是标题行
            {
                // 获取修改后的数据
                var updatedOrder = dataGridView1.Rows[e.RowIndex].DataBoundItem as Node;

                if (updatedOrder != null)
                {
                    using (var context = new MyDB())
                    {
                        // 更新数据库
                        context.Entry(updatedOrder).State = EntityState.Modified;
                        context.SaveChanges();
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
