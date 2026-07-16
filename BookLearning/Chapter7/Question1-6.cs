using System;
using System.Collections.Generic;
using System.Text;

namespace BookLearning.Chapter7
{
    internal class Question6
    {
        static public void Run()
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine()!);
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine()!);

            Console.WriteLine($"a + b = {a + b}");
            Console.WriteLine($"a - b = {a - b}");
            Console.WriteLine($"a * b = {a * b}");
            Console.WriteLine($"a / b = {a / b}");
            Console.WriteLine($"a % b = {a % b}");
        }
    }
}
