using System;
using System.Collections.Generic;
using System.Text;

namespace Bookreview.Chapter5
{
    internal class Sample509
    {
        static public void Run()
        {
            Vector v = new Vector();

            v.X = 0.1;
            v.Y = 0.2;

            Console.WriteLine($"v = {v.X}, {v.Y}");
        } 
    }

    abstract class VectorBase
    {
        public abstract double X
        {
            set; get;
        }

        public abstract double Y
        {
            set; get;
        }
    }

    class Vector : VectorBase
    {
        private double x = 0.0;
        private double y = 0.0;

        //プロパティの実装
        public override double X
        {
            set { x = value; }
            get { return x; }
        }

        public override double Y
        {
            set {  y = value; }
            get { return y; }
        }
    }
}
