using MYLIST;
using System;

namespace SCF_Homework_4._1
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Random ran=new Random();
            MyList<int> l = new MyList<int>();
            for(int i=0;i<10;i++)
            {
                l.Add(ran.Next(20));
            }
            node<int> p = l.Head;
            int sum = 0;
            int min =p.Data ;
            int max =p.Data ;
            l.ForEach(n=>sum+=n);
            l.ForEach(n => min= min < n ? min : n);
            l.ForEach(n => max = max > n ? max : n);
            l.ForEach(n => Console.Write($"{n} "));
            Console.Write($"\n最大值为{max}，最小值为{min},数据和为{sum}。");
        }
    }
}
