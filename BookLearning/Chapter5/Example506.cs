using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace BookLearning.Chapter5
{
    internal class Example506
    {
        static void DriveACar(IDrive car)
        {
            Console.WriteLine(car.Drive());
            //Console.WriteLine(car.Maintain());
        }

        static void MaintainACar(IMechanical car)
        {
            //Console.WriteLine(car.Drive());
            Console.WriteLine(car.Maintain());
        }

        static public void Run()
        {
            Car c = new Car();
            DriveACar(c);
            MaintainACar(c);
        }
    }

    class Car : IDrive, IMechanical
    {
        //運転メソッド
        public string Drive()
        {
            return "運転する";
        }
        //メンテナンスメソッド
        public string Maintain()
        {
            return "メンテナンスする";
        }
    }

    interface IDrive
    {
        string Drive();
    }

    interface IMechanical
    {
        string Maintain();
    }
}
