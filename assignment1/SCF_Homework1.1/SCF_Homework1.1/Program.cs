using System;

namespace SCF_Homework1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入您的算式,以空格分隔各字符");
            string input=Console.ReadLine();
            string[] part = input.Split(' ');
            float a = float.Parse(part[0]);
            float b = float.Parse(part[2]);
            char op = char.Parse(part[1]);
            float result = 0;
            if (op=='+')
            {
                result = a + b;
            }
            else if(op=='-')
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
            Console.WriteLine($"{result}");
        }
    }
}
