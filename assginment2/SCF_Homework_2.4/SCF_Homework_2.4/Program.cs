namespace SCF_Homework_2._4
{
    internal class Program
    {
        static void M(int[,]a,out bool x)
        {
            x = false;
            for(int i = 0; i < a.GetLength(0)-1;i++)
            {
                for(int j=0;j<a.GetLength(1)-1;j++)
                {
                    if (a[i, j] != a[i + 1, j + 1])
                        return;
                }
            }
            x = true;
            return;
        }
        static void Main(string[] args)
        {
            Random ran = new Random();
            int a1 = ran.Next(2,5);
            int a2 = ran.Next(2, 5);
            int[,] a = new int[a1, a2];
            for(int i=0;i<a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = ran.Next(2, 4); ;
                    Console.Write(a[i, j] + " ");
                }
                Console.Write("\n");
            }
            bool ans;
            M(a, out ans);
            if (ans) Console.WriteLine("是托普利茨矩阵");
            else Console.WriteLine("不是托普利茨矩阵");
        }
    }
}
