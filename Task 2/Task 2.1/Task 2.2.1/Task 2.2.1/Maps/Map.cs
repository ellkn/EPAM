using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2._2._1.Bonuses;
using Task_2._2._1.Common;
using Task_2._2._1.Enemy;
using Task_2._2._1.Obstacles;
using Task_2._2._1.Players;

namespace Task_2._2._1.Maps
{
    public class Map
    {
        public int Width { get; set; }
        public int Height { get; set; }
        protected List<GameObject> gameObjects;
        protected List<Cat> cats;
        protected List<Snake> snakes;
        protected List<Cheese> cheeses;
        protected List<GameObject> obstracles;
        protected bool isWin;
        public Mouse? Mouse { get; private set; }
        Random random = new Random();
        public Map()
        {
            Width = 100;
            Height = 25;
        }
        public Map(int width, int height)
        {
            Width = width;
            Height = height;
            gameObjects = new List<GameObject>();
            isWin = false;
            snakes = new List<Snake>();
            cats = new List<Cat>();
            Mouse mouse = new Mouse();
        }
        public void MapWrite()
        {
            for (int i = 1; i <= Width; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.Write("─");
            }
            for (int i = 1; i <= Width; i++)
            {
                Console.SetCursorPosition(i, Height + 1);
                Console.Write("─");
            }
            for (int i = 1; i <= Height; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("│");
            }
            for (int i = 1; i <= Height; i++)
            {
                Console.SetCursorPosition(Width + 1, i);
                Console.Write("│");
            }
            Console.SetCursorPosition(0, 0);
            Console.Write("┌");
            Console.SetCursorPosition(Width + 1, 0);
            Console.Write("┐");
            Console.SetCursorPosition(0, Height + 1);
            Console.Write("└");
            Console.SetCursorPosition(Width + 1, Height + 1);
            Console.Write("┘");
        }

        public void InstatiateObstracles()
        {
            int numberOfTrees = random.Next(Width * Height / 4);
            for (int i = 0; i < numberOfTrees; ++i)
            {
                Point point = new Point(random.Next(Width), random.Next(Height));
                Trees trees = new Trees(point);
                obstracles.Add(trees); // showed error
                Stones stones = new Stones(point);
                obstracles.Add(stones);
            }
        }
        public void InstatiateEnemy()
        {
            int numberOfEnemies = random.Next(Width * Height / 10);
            for (int i = 0; i < numberOfEnemies; ++i)
            {
                Point point = new Point(random.Next(Width), random.Next(Height));
                Cat cat = new Cat(point);
                cats.Add(cat);
                Snake snake = new Snake(point);
                snakes.Add(snake);
            }
        }

        public void InstantiateMouse()
        {
            Point point = new Point(random.Next(Width), random.Next(Height));
            Mouse = new Mouse(point);
            gameObjects.Add(Mouse);
        }
        public void InstantiateBonuses()
        {
            Point point = new Point(random.Next(Width), random.Next(Height));
            Cheese cheese = new Cheese(point);
            cheeses.Add(cheese);
        }
    }
}
