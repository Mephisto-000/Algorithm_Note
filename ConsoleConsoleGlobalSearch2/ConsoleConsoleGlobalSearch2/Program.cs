using System;

/*
 *  取得特定元素存在的 "注標"
*/
namespace ConsoleConsoleGlobalSearch2
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
            int found_id = -1;  // 初始值設為 -1 等不可能的值
            for (int i = 0; i < N; i++)
            {
                if (vec[i] == v)
                {
                    found_id = i;  // 找到的話就紀錄注標
                    break;
                }
            }

            if (found_id == -1)
                Console.WriteLine("沒有找到。");
            else
                Console.WriteLine($"位置 : {found_id}");
        }
    }
}
