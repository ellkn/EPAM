using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Task_2._2._1.Bonuses;
using Task_2._2._1.Common;
using Task_2._2._1.Enemy;
using Task_2._2._1.Maps;
using Task_2._2._1.Players;

namespace Task_2._2._1.Handlers
{
    public class GameHandler
    {
        Map map = new Map();
        Mouse mouse = new Mouse();
        public void Run()
        {
            Console.Clear();
            map.MapWrite();
            //map.InstatiateObstracles();
            //map.InstatiateEnemy();
            //map.InstantiateBonuses();
            //map.InstantiateMouse();
            while (!mouse.IsOver)
            {
                char key = char.Parse(Console.ReadLine());
                switch (key)
                {
                    case 'a':
                        mouse.PlayersMove(1, map);
                        break;
                    case 'w':
                        mouse.PlayersMove(2, map);
                        break;
                    case 'd':
                        mouse.PlayersMove(3, map);
                        break;
                    case 's':
                        mouse.PlayersMove(4, map);
                        break;
                    default:
                        break;
                }
                
            }
        }       
    }
}
