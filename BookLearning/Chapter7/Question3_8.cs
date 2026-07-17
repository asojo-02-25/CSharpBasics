using System;
using System.Collections.Generic;
using System.Text;

namespace BookLearning.Chapter7
{
    internal class Question3_8
    {
        static public void Run()
        {
            for (int i = 1; i <= 100; i++)
            {
                for (int j = 2; j <= i; j++)
                {
                    if (i == j)
                    {
                        Console.Write($"{i} ");

                    }
                    if (i % j == 0)
                    {
                        break;
                    }
                }
            }
        }
    }
}

