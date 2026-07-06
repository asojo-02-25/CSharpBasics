using System;
using System.Collections.Generic;
using System.Text;

namespace BookLearning.Chapter5
{
    class Sample504
    {
        static public void Run()
        {
            Sub s1 = new Sub();
            s1.showParam();
            Sub s2 = new Sub(100);
            s2.showParam();
        }

        internal class Super
        {
            private int param = 0;
            public Super() : this(0)
            {
            }

            public Super(int param)
            {
                this.param = param;
                Console.WriteLine($"Superクラスのコンストラクタ(引数 : {param})");
            }

            public void showParam()
            {
                Console.WriteLine($"param = {param}");
            }
        }

        internal class Sub : Super
        {

            public Sub() : this(0)
            {

            }

            public Sub(int param)
            {
                Console.WriteLine($"Subクラスのコンストラクタ(引数 : {param})");
            }
        }
    }
}
