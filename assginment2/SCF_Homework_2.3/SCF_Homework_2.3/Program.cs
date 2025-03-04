namespace SCF_Homework_2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[99];
            for (int i=2;i<=100;i++)
            {
                arr[i-2] = i;
            }
            for (int i=2;i<=10;i++)
            {
                for(int j=0;j<arr.Length;j++)
                {
                    if (arr[j] != -1 && arr[j] % i == 0 && arr[j]!=i)
                        arr[j] = -1;
                }
            }
            foreach( int k in arr)
            {
                if(k!=-1)
                   Console.Write(k + " ");
            }
        }
    }
}
