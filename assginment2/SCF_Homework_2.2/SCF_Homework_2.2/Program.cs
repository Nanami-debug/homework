using System;
namespace SCF_Homework_2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random ran = new Random();
            int[] arr = new int[10];
            Console.WriteLine("数组内容为：");
            for (int i=0;i<arr.Length;i++)
            {
                arr[i] = ran.Next(20);
                Console.Write(arr[i]+" ");
            }

            int sum = 0;
            int max = arr[0];
            int min = arr[0];
            foreach(int i in arr)
            {
                max = max > i ? max : i;
                min = min < i ? min : i;
                sum += i;
            }
            Console.Write("\n最大值为" + max + " 最小值为" + min + " 数据和为" + sum + " 平均值为" + (sum / arr.Length));
        }
    }
}
