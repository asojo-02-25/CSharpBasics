using System;
using System.Collections.Generic;
using System.Text;

namespace Bookreview.Chapter6
{
    delegate int Operation(int a, int b);
    internal class Example602
    {
        static public void Run()
        {
            Calculation c = new Calculation();

            //デリゲートの設定
            Operation o1 = new Operation(Add);
            Operation o2 = new Operation(c.Sub);

            Console.WriteLine($"{2} + {1} = {o1(2, 1)}");
            Console.WriteLine($"{2} - {1} = {o2(2, 1)}");
        }

        static Operation Add = (a, b) => (a + b);
    }

    class Calculation
    {
        public Operation Sub = (a, b) => (a - b);
    }
}
