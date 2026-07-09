using System;
using System.Collections.Generic;
using System.Text;

namespace Bookreview.Chapter5
{
    internal class Parent
    {
        public virtual void Foo()
        {
            Console.WriteLine("親クラスのFooメソッド");
        }
    }

    class Child : Parent
    {
        public override void Foo()
        {
            Console.WriteLine("子クラスのFooメソッド");
        }
    }

    class Sample505
    {
        public static void Run()
        {
            Parent p = new Parent();
            Child c = new Child();

            p.Foo();
            c.Foo();
        }
    }
}
