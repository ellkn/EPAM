using System;
using Task_2._1._2.Logic; 

namespace Task_2._1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Первый вход в программу! Необходимо совершить вход");
            Console.WriteLine("Введите имя пользователя:");
            User currentUser = new User()
            {
                Name = ActionHandler.GetConsoleStringValue()
            };
            ActionHandler actionHandler = new ActionHandler(currentUser);
            Console.WriteLine("Текущий пользователь: " + currentUser);
            int currentFuncton;
            do
            {
                ActionHandler.PrintMenu();
                currentFuncton = ActionHandler.GetConsoleIntValue();
                switch (currentFuncton)
                {
                    case 1:
                        actionHandler.AddFigure(currentUser);
                        break;
                    case 2:
                        actionHandler.ShowAllFigures(currentUser);
                        break;
                    case 3:
                        actionHandler.DeleteAllFigures(currentUser);
                        break;
                    case 4:
                        actionHandler.ChangeUser();
                        break;
                    case 0:
                        break;
                    default:
                        break;
                }
            } while (currentFuncton != 0);
        }
    }
}
