using System;
using System.Collections.Generic;
using System.Text;

namespace BookLearning.Chapter7
{
    internal class Question3_4
    {
        static public void Run()
        {
            Console.Write("数を入力");
            int num = int.Parse(Console.ReadLine()!);

            Console.WriteLine("2の倍数");
            for (int i = 1; i <= num; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write($"{i} ");
                }
            }
            Console.WriteLine();

            Console.WriteLine("3の倍数");
            for (int i = 1; i <= num; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write($"{i} ");
                }
            }
            Console.WriteLine();

            Console.WriteLine("5の倍数");
            for (int i = 1; i <= num; i++)
            {
                if (i % 5 == 0)
                {
                    Console.Write($"{i} ");
                }
            }
            Console.WriteLine();
        }
    }
}
