using System;
using System.Collections.Generic;
using System.Text;

namespace BookLearning.Chapter7
{
    internal class Question3_1
    {
        static public void Run()
        {
            Console.Write("回数を入力");
            int num = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("HelloC#!");
            }
        }
    }
}
