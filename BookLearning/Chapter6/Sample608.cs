using System;
using System.Collections.Generic;
using System.Text;

namespace BookLearning.Chapter6
{
    internal class Sample608
    {
        static public void Run()
        {
            try
            {
                for (int i = 0; i <= 5; i++)
                {
                    int a = GetNum(i);
                    int b = 5;
                    Console.Write($"{a} / {b} = ");
                    Console.WriteLine(Calc(a, b));
                }
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine();
                Console.WriteLine("0による除算が発生しました。");
                Console.WriteLine(e.Message);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine();
                Console.WriteLine("範囲外へのアクセスが発生しました。");
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("終了");
            }
        }

        private static int Calc(int a, int b)
        {
            return a / b;
        }

        public static int GetNum(int index)
        {
            int[] num = { 1, 2, 3, 4 };
            return num[index];
        }
    }
}
