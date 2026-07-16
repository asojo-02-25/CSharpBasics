using System;
using System.Collections.Generic;
using System.Text;

namespace BookLearning.Chapter7
{
    internal class Question2_1
    {
        static public void Run()
        {
            Console.WriteLine("整数値を入力してください");
            int num = int.Parse(Console.ReadLine()!);
            Console.WriteLine($"{num}です");
        }
    }
}
