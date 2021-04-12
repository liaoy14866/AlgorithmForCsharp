using System;

namespace My_Algorithm
{
    static class Algorithm
    {
        public static Random rand = new Random();
        public static void Swap(ref int a,ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }
        public static void Sort(int[] arr, int l, int r)
        {
            //应该是左闭右开的区间
            int tl = l, tr = r - 1, x = arr[rand.Next(l, r)];
            //选择左右两端的数，注意tr是r-1
            while (tl < tr) 
            {
                while (arr[tl] < x) tl++;
                while (arr[tr] > x) tr--;
                if (tl <= tr)
                {
                    Swap(ref arr[tl], ref arr[tr]);
                    tl++;
                    tr--;
                }
            }
            if (l < tr) Sort(arr, l, tr + 1); //大于两个数需要继续排序
            if (tl < r - 1) Sort(arr, tl, r);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] userinput = Console.ReadLine().Split(' ');
            int[] A = new int[userinput.Length];
            for (int i = 0; i < userinput.Length; i++)
            {
                A[i] = int.Parse(userinput[i]);
            }
            Algorithm.Sort(A, 0, A.Length);
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write(A[i] + " ");
            }
        }
    }
}

