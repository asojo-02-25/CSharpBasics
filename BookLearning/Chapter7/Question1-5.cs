using System;
using System.Collections.Generic;
using System.Text;

namespace BookLearning.Chapter7
{
    internal class Question5
    {
        static public void Run()
        {
            Console.Write("あなたの姓を入力してください : ");
            string lastname = Console.ReadLine()!;
            Console.Write("あなたの名前を入力してください : ");
            string firstname = Console.ReadLine()!;

            Console.WriteLine($"あなたは{lastname}{firstname}さんですね。");
        } 
    }
}
