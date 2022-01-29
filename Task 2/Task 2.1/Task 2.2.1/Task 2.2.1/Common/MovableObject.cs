using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2._2._1.Abstract;
using Task_2._2._1.Maps;

namespace Task_2._2._1.Common
{
    public class MovableObject : GameObject, IMovable
    {
        protected Map map;
        protected Point step;
        protected bool isMoving;
        //ConsoleKeyInfo keyInfo;
        //ConsoleKey consoleKey;
        public MovableObject() : this(Point.Zero)
        {
            //keyInfo = new ConsoleKeyInfo();
            //consoleKey = new ConsoleKey();
        }

        public MovableObject(Point point) : base(point)
        {
            
        }
        
        public void EnemyMove()
        {
            //todo
        }

        public void PlayersMove(int direction, Map map)
        {
            this.map = map;
            step = new Point(Position.X, Position.Y);
            switch (direction)
            {
                case 1: 
                    step = new Point(Position.X - 1, Position.Y);
                    break;
                case 2:
                    step = new Point(Position.X, Position.Y - 1);
                    break;
                case 3:
                    step = new Point(Position.X+1, Position.Y);
                    break;
                case 4:
                    step = new Point(Position.X, Position.Y + 1);
                    break;
                default:
                    break;
            }
            if(step.X >= map.Width || step.Y >= map.Height || step.X < 0 || step.Y < 0)
            {
                isMoving = false;
                return;
            }
        }
        /*void Input()
        {
            if (Console.KeyAvailable)
            {
                keyInfo = Console.ReadKey(true);
                consoleKey = keyInfo.Key;
            }
        }
        void Up()
        {
            Write("");
            mousePosition.Y--;
            Write();
        }
        void Down()
        {
            Write("\0");
            mousePosition.Y++;
            Write();
        }
        void Left()
        {
            Write("\0");
            mousePosition.X--;
            Write();
        }
        void Right()
        {
            Write("\0");
            mousePosition.X++;
            Write();
        }
        public void Write()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(mousePosition.X, mousePosition.Y);
            Console.Write("M");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void Write(string str)
        {
            Console.SetCursorPosition(mousePosition.X, mousePosition.Y);
            Console.Write(str);
            Console.ForegroundColor = ConsoleColor.White;
        }*/


        /* public void PlayersMove()
        { 
        Input();
        switch (consoleKey)
         {
             case ConsoleKey.A:
                 Left();
                 break;
             case ConsoleKey.LeftArrow:
                 Left();
                 break;
             case ConsoleKey.W:
                 Up();
                 break;
             case ConsoleKey.UpArrow:
                 Up();
                 break;
             case ConsoleKey.S:
                 Down();
                 break;
             case ConsoleKey.DownArrow:
                 Down();
                 break;
             case ConsoleKey.D:
                 Right();
                 break;
             case ConsoleKey.RightArrow:
                 Right();
                 break;
         }*/
        //}

    }
}
