using System.Windows.Forms;
using ORDER_SERVICE;
using FORM2;
using ORDER;
using FORM3;
using FORM4;
using FORM5;
using FORM6;
using static System.Windows.Forms.DataFormats;
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
            Form2 form2 = new Form2(service.count);

            if (form2.ShowDialog() == DialogResult.OK)
            {
                // 获取 Form2 传递的对象
                service.orders.Add(form2.order);
                service.count++;
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
                // 获取 Form2 传递的对象
                service = form4.o;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5(service);

            if (form5.ShowDialog() == DialogResult.OK)
            {
                // 获取 Form2 传递的对象
                service = form5.o;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6(service);
            form6.ShowDialog();
        }
    }
}
