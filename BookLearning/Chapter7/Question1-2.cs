using System;
using System.Collections.Generic;
using System.Text;

namespace BookLearning.Chapter7
{
    internal class Question2
    {
        static public void Run()
        {
            Console.WriteLine("半径を入力してください");
            double r = double.Parse(Console.ReadLine()!);
            double s = r * r * Math.Round(Math.PI);
            double t = 2 * r * Math.Round(Math.PI);

            Console.WriteLine($"面積 : {s}, 周の長さ : {t}");
        }
    }
}
