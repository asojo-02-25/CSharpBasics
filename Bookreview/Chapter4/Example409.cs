using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Bookreview
{
    class Example409
    {
        static public void Run()
        {
            Console.WriteLine("サイズを入力してください");
            int size = int.Parse(Console.ReadLine()!);

            Bingo409 data = new Bingo409(size);
            data.Show();
        }
    }

    class Bingo409
    {
        private int size = 0;
        private int[,] data = new int[0, 0];

        public Bingo409() :this(5) 
        {

        }

        public Bingo409(int size)
        {
            this.size = size;
            Init();
        }

        private void Init()
        {
            this.data = new int[size, size];

            Shuffle();
        }

        private void Shuffle()
        {
            Random rnd = new Random();
            int num = 1;

            while (num <= size * size)
            {
                int m = rnd.Next(size);
                int n = rnd.Next(size);

                if (data[m, n] == 0)
                {
                    data[m, n] = num;
                    num++;
                }
            }
        }

        public void Show()
        {
            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    Console.Write($"{data[i, j],2:d} |");
                }
                Console.WriteLine();
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    Console.Write("---");
                }
                Console.WriteLine();
            }
        }
    }
}
