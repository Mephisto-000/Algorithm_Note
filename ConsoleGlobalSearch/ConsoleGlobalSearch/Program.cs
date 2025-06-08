using System;
using System.Collections;


namespace ConsoleGlobalSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, v;
            Console.WriteLine("請輸入陣列長度 : ");
            N = Console.Read();
            int [] vec = new int [N];

            Console.WriteLine("請輸入要尋找的元素 : ");
            v = Console.Read();

            Console.WriteLine("請依序輸入陣列元素 : ");
            for (int i = 0; i < N; i++)
            {
                vec [i] = Console.Read();
            }

            bool exist = false;
            for (int i = 0; i < N; i++)
            {
                if (vec[i] == v)
                {
                    exist = true;
                    break;
                }
            }

            if (exist)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}
