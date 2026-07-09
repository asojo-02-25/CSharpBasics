using System;
using System.Collections.Generic;
using System.Text;

namespace Bookreview.Chapter5
{
    internal class Sample508
    {
        static public void Run()
        {
            Crow c = new Crow();
            Sparrow s = new Sparrow();

            Console.Write(c.Name + " ");
            c.Sing();

            Console.Write(s.Name + " ");
            s.Sing();
        }
    }

    abstract class Bird
    {
        private string name;

        public Bird(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return name; }
        }

        public abstract void Sing();
    } 

    class Crow : Bird
    {
        public Crow() : base("カラス")
        {
        }

        public override void Sing()
        {
            Console.WriteLine("カーカー");
        }
    }

    class Sparrow : Bird
    {
        public Sparrow() : base("スズメ")
        {
        }

        public override void Sing()
        {
            Console.WriteLine("チュンチュン");
        }
    }
}
