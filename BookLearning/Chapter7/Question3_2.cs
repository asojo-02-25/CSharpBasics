using System;
using System.Collections.Generic;
using System.Text;

namespace BookLearning.Chapter7
{
    internal class Question3_2
    {
        static public void Run()
        {
            Console.Write("forループ : ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

            int j = 0;
            Console.Write("whileループ : ");
            while(j < 5)
            {
                Console.Write("*");
                j++;
            }
            Console.WriteLine();

            int k = 0;
            Console.Write("forループ : ");
            do
            {
                Console.Write("*");
                k++;
            } while(k < 5);
            Console.WriteLine();
        }
            
    }
}
