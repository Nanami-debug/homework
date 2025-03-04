using System;


namespace SCF_Homework_2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入你需要的素数范围\n");
            string input=Console.ReadLine();
            int n = int.Parse(input);
            if (n == 1) Console.WriteLine("该范围内没有素数");
            for(int i=2;i<=n;i++)
            {
                bool flag = true;
                for (int j=2;j<=i/2;j++)
                {
                    if (i % j == 0)
                    {
                        flag = false;
                        break;
                    }   
                }
                if(flag) Console.WriteLine(i);
            }
        }
    }
}
