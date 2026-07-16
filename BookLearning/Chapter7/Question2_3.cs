using System;
using System.Collections.Generic;
using System.Text;

namespace BookLearning.Chapter7
{
    internal class Question2_3
    {
        static public void Run()
        {
            Console.Write("テストの点数を入力してください(0 - 100) : ");
            int score = int.Parse(Console.ReadLine()!);

            if (score < 0 || score > 100) {
                Console.WriteLine("不適切な値です");
                return;
            }

            if (0 <= score && score < 60)
            {
                Console.WriteLine("不可");
            }
            else if(score < 70)
            {
                Console.WriteLine("可");
            }
            else if (score < 80)
            {
                Console.WriteLine("良");
            }
            else if (score <= 100)
            {
                Console.WriteLine("優");
            }
        }
    }
}
