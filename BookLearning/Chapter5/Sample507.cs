using System;
using System.Collections.Generic;
using System.Text;

namespace BookLearning.Chapter5
{
    internal class Sample507
    {
        static public void Run()
        {
            Crow c = new Crow();
            Console.WriteLine(c.Name + ":");
            c.Sing();
            Sparrow s = new Sparrow();
            Console.WriteLine(s.Name + ":");
            s.Sing();
        }
    }

    internal class Crow
    {
        private String name = "カラス";

        public void Sing()
        {
            Console.Write("カーカー");
        }

        public String Name
        {
            get { return name; }
        }
    }

    internal class Sparrow
    {
        private String name = "すずめ";

        public void Sing()
        {
            Console.Write("チュンチュン");
        }

        public String Name
        {
            get { return name; }
        }
    }
}
