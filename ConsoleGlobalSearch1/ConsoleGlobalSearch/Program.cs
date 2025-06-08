using System;


namespace ConsoleGlobalSearch1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, v;

            // 提示並讀入陣列長度
            Console.Write("請輸入陣列長度 : ");
            N = int.Parse(Console.ReadLine());

            // 建立整數陣列
            int[] vec = new int[N];

            // 提示並讀入目標值
            Console.Write("請輸入要尋找的元素 : ");
            v = int.Parse(Console.ReadLine());

            // 提示並逐一讀入陣列元素
            Console.WriteLine("請依序輸入陣列元素 : ");
            for (int i = 0; i < N; i++)
            {
                vec[i] = int.Parse(Console.ReadLine());
            }

            // 線性搜尋
            bool exist = false;
            for (int i = 0; i < N; i++)
            {
                if (vec[i] == v)
                {
                    exist = true;
                    break;
                }
            }

            // 輸出結果
            if (exist)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}
