using System;
using System.Collections.Generic;
using System.Text;

namespace BookLearning.Chapter7
{
    internal class Question4
    {
        static public void Run()
        {
            Console.WriteLine("幅を入力");
            double width = double.Parse(Console.ReadLine()!);
            Console.WriteLine("奥行を入力");
            double depth = double.Parse(Console.ReadLine()!);
            Console.WriteLine("高さを入力");
            double height = double.Parse(Console.ReadLine()!);

            Console.WriteLine($"立方体の体積 : {(width * depth * height):F2}(cm3)");
        }
    }
}
