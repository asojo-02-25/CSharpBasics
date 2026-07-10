using System;
using System.Collections.Generic;
using System.Text;

namespace Bookreview.Chapter6
{
    internal class Sample605
    {
        delegate int Operation(int a, int b);
        static public void Run()
        {
            Calc c = new Calc();

            //デリゲートの設定
            Operation o1 = new Operation(Add);
            Operation o2 = new Operation(c.Sub);

            Console.WriteLine($"{2} + {1} = {o1(2, 1)}");
            Console.WriteLine($"{2} - {1} = {o2(2, 1)}");
        }

        static int Add(int a, int b)
        {
            return a + b;
        }
    }

    class Calc
    {
        public int Sub(int a, int b)
        {
            return a - b;
        }
    }
}
