using System;
using System.Collections.Generic;
using System.Text;

namespace BookLearning.Chapter5;

class Sample509
{
    public static void Run()
    {
        Vector v = new Vector();
        v.X = 0.1;
        v.Y = 0.2;

        Console.WriteLine($"v = {v.X}, {v.Y}");
    }

    abstract class VectorBase
    {
        public abstract double X
        {
            get; set;
        }

        public abstract double Y
        {
            get; set;
        }
    }

    class Vector : VectorBase
    {
        private double x = 0.0;
        private double y = 0.0;

        public override double X
        {
            set { x = value; }
            get { return x; }
        }

        public override double Y
        {
            set { y = value; }
            get { return y; }
        }
    }
}
