using MyForm;
namespace SCF_Homework_4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Form form1 = new Form();
            form1.clock1.open(10);
            form1.clock1.close();
            form1.clock1.alarm_after(10);
        }
    }
}
