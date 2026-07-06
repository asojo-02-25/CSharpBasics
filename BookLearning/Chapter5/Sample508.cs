using System;
using System.Collections.Generic;
using System.Text;

namespace BookLearning.Chapter5
{
    internal class Sample508
    {
        static public void Run()
        {
            Bird[] b = new Bird[2];
            b[0] = new Crow508();
            b[1] = new Sparrow508();

            foreach (Bird bird in b)
            {
                Console.Write(bird.Name + ":");
                bird.Sing();
            }
        }               
    }

    abstract class Bird
    {
        private string name;

        //引数付きコンストラクタ
        public Bird(string name)
        {
            this.name = name;
        }

        //名前を取得
        public string Name
        {
            get { return name; }
        }

        //鳴く
        public abstract void Sing();
    }

    class Crow508 : Bird
    {
        //コンストラクタ
        public Crow508() : base("カラス")
        {

        }

        //カラスが鳴く
        public override void Sing()
        {
            Console.WriteLine("カーカー");
        }
    }

    class Sparrow508 : Bird
    {
        //コンストラクタ
        public Sparrow508() : base("すずめ")
        {

        }

        //すずめが鳴く
        public override void Sing()
        {
            Console.WriteLine("チュンチュン");
        }
    }
}
