using System;
using Task_2._2._1.Handlers;

namespace Task_2._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Game";
            Console.CursorVisible = false;
            GameHandler game = new GameHandler();
            game.Run();
            Console.ReadKey();
        }
        //it is necessary to finalize all the elements.
        //there is a drawing of the map.
        //in one of the versions, there was the placement of the player and his movement. currently, it is not displayed in the console yet.
        //there is a conditional placement of objects on the map.needs to be finalized
    }
} 