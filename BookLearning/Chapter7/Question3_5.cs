using System;
using System.Collections.Generic;
using System.Text;

namespace BookLearning.Chapter7
{
    internal class Question3_5
    {
        static public void Run()
        {
            Random rnd = new Random();
            int min = 101;
            int max = 0;

            for (int i = 0; i < 5; i++)
            {
                int num = rnd.Next(1, 101);
                
                if (num < min)
                {
                    min = num;
                }

                if (num > max)
                {
                    max = num;
                }
                Console.Write($"{num} ");
            }

            Console.WriteLine($"最大値 : {max}");
            Console.WriteLine($"最小値 : {min}");
        }
    }
}
