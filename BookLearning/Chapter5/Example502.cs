using System;
using System.Collections.Generic;
using System.Text;

namespace BookLearning.Chapter5
{
    class Example502
    {
        static public void Run()
        {
            Console.WriteLine("角度を入力してください");
            double angle = double.Parse(Console.ReadLine()!);
            double rad = Math.PI * angle / 180;

            Console.WriteLine($"sin{angle}°= {Math.Sin(rad)}");
            Console.WriteLine($"cos{angle}°= {Math.Cos(rad)}");
            Console.WriteLine($"tan{angle}°= {Math.Tan(rad)}");
        }
    }
}
