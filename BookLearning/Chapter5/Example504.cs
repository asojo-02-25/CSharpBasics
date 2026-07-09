using System;
using System.Collections.Generic;
using System.Text;

namespace BookLearning.Chapter5
{
    internal class Example504
    {
        static public void Run()
        {
            Ship ship = new Ship();
            BattleShip battleship = new BattleShip();

            ship.Sail();
            battleship.Sail();
            battleship.Fight();
        } 

        class Ship
        {
            public void Sail()
            {
                Console.WriteLine("航海する");
            }
        }

        class BattleShip : Ship
        {
            public void Fight()
            {
                Console.WriteLine("戦闘する");
            }
        }
    }
}
