using System;
using System.Collections.Generic;
using System.Text;

namespace BookLearning.Chapter7
{
    internal class Question3
    {
        static public void Run()
        {
            Console.WriteLine("aの値を入力してください");
            double a = double.Parse(Console.ReadLine()!);
            Console.WriteLine("bの値を入力してください");
            double b = double.Parse(Console.ReadLine()!);
            Console.WriteLine("cの値を入力してください");
            double c = double.Parse(Console.ReadLine()!);

            Console.WriteLine($"a + b + c = {Math.Round((a + b + c), 1):F1}");
            Console.WriteLine($"a, b, cの平均 : {Math.Round(((a + b + c) / 3), 1):F1}");
        }
    }
}
