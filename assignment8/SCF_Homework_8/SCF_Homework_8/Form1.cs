using System.Windows.Forms;
using ORDER_SERVICE;
using FORM2;
using ORDER;
using FORM3;
using FORM4;
using FORM5;
using FORM6;
using static System.Windows.Forms.DataFormats;
using Microsoft.EntityFrameworkCore;
using ORDER_DATAIL;
using Myd;
namespace SCF_Homework_6._1
{
    public partial class Form1 : Form
    {
        public Order_Service service;
        public Form1()
        {
            InitializeComponent();
            service = new Order_Service();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int maxOrderId = 0;
            using (var context = new MyDB())
            {
                maxOrderId = context.Orders.Max(o => (int?)o.id) ?? 0;
            }

            Form2 form2 = new Form2(maxOrderId);

            if (form2.ShowDialog() == DialogResult.OK)
            {
                // ��ȡ Form2 ���ݵĶ���
                //service.orders.Add(form2.order);
                //service.count++;
                using (var context = new MyDB())
                {
                    context.Orders.Add(form2.order); // ��Ӷ���
                    context.SaveChanges();     // �������
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(service);
            form3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(service);

            if (form4.ShowDialog() == DialogResult.OK)
            {
                // ��ȡ Form2 ���ݵĶ���
                service = form4.o;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5(service);

            if (form5.ShowDialog() == DialogResult.OK)
            {
                // ��ȡ Form2 ���ݵĶ���
                service = form5.o;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6(service);
            form6.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
