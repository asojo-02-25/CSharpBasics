using System;
using System.Collections.Generic;
using System.Text;

namespace BookLearning.Chapter7
{
    internal class Question3_3
    {
        static public void Run()
        {
            Console.Write("回数を入力");
            int num = int.Parse(Console.ReadLine()!);

            for (int i = num; i > 0; i--)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
