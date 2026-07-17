using System;
using System.Collections.Generic;
using System.Text;

namespace BookLearning.Chapter7
{
    internal class Question3_6
    {
        static public void Run()
        {
            Console.Write("文字を入力 : ");
            string? text = Console.ReadLine();

            if (string.IsNullOrEmpty(text))
            {
                return;
            }

            Console.WriteLine(text);
        }
    }
}
