using System;
using System.Collections.Generic;
using System.Text;

namespace BookLearning.Chapter7
{
    internal class Question2_2
    {
        static public void Run()
        {
            Console.WriteLine("整数値を入力してください");
            int num = int.Parse(Console.ReadLine()!);

            if (num == 0)
            {
                Console.WriteLine("0です");
            }
            else
            {
                Console.WriteLine("0ではありません");
            }
        }
    }
}
