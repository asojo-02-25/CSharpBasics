using System;
using System.Collections.Generic;
using System.Text;

namespace BookLearning.Chapter5
{
    internal class Example503
    {
        static public void Run()
        {
            Console.WriteLine("ビンゴのサイズを入力してください");
            int size = int.Parse(Console.ReadLine()!);

            Bingo503 card = new Bingo503(size);
            card.Show();
        } 

        class Bingo503
        {
            private int size = 0;
            private int[,] card = new int[0, 0];

            public Bingo503() : this(5)
            {
            }

            public Bingo503(int size)
            {
                this.size = size;
                this.card = new int[size, size];
                Clear();
                Shuffle();
            }

            private void Clear()
            {
                Console.WriteLine(card);
                Array.Clear(card, 0, size * size);
                Console.WriteLine(card);
            }

            private void Shuffle()
            {
                Random rnd = new Random();
                int num = 1;

                while (num <= size * size)
                {
                    int n = rnd.Next(size);
                    int m = rnd.Next(size);

                    if (card[n, m] == 0)
                    {
                        card[n, m] = num;
                        num++;
                    }
                }
            }

            public void Show()
            {
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        Console.Write($"{card[i, j], 2:d} |");
                    }
                    
                    Console.WriteLine();
                    
                    for (int j = 0; j < size; j++)
                    {
                        Console.Write("----");
                    }

                    Console.WriteLine();
                }
            } 

        }
    }
}
