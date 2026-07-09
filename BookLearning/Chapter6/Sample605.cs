using System;
using System.Collections.Generic;
using System.Text;

namespace BookLearning.Chapter6;

delegate int Operation(int a, int b);

internal class Sample605
{
    static public Operation Add = (int a, int b) => (a + b);

    static public void Run()
    {
        Calc c = new Calc();
        Operation o1 = Add;
        Operation o2 = c.Sub;

        Console.WriteLine($"{2} + {1} = {o1(2, 1)}");
        Console.WriteLine($"{2} - {1} = {o2(2, 1)}");
    }
}

class Calc
{
    public Operation Sub = (int a, int b) => (a - b);
}
