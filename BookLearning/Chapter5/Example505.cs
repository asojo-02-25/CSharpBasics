using System;
using System.Collections.Generic;
using System.Text;

namespace BookLearning.Chapter5
{
    internal class Example505
    {
        static public void Run()
        {
            Mammals[] animals = new Mammals[2];
            animals[0] = new Cats();
            animals[1] = new Mice();
            
            foreach (var animal in animals)
            {
                Console.WriteLine(animal.ShowName());
                Console.WriteLine(animal.Bark());
                Console.WriteLine("----------------");
            }
        }

        abstract class Mammals
        {
            protected string name = "";

            public abstract string Bark();

            public string ShowName()
            {
                return ($"名前 : {name}");
            }
        }

        class Cats : Mammals
        {
            public Cats()
            {
                this.name = "猫";
            }

            public override string Bark()
            {
                return "ニャーニャー";
            }
        }

        class Mice : Mammals
        {
            public Mice()
            {
                this.name = "ネズミ";
            }

            public override string Bark()
            {
                return "チューチュー";
            }
        }
    }
}
