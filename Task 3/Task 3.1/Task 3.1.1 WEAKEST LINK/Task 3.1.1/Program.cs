using System;

namespace Task_3._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input;
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("\t1. Игра");
                Console.WriteLine("\t2. Выход");
                input = GetConsoleIntValue();
                Console.ForegroundColor= ConsoleColor.White;
                switch (input)
                {
                    case 1:
                        Console.Write("Введите количество игроков (N): ");
                        int capacity = GetConsoleIntValue();
                        Console.Write("Введите номер игрока, выбывающего в каждом раунде: ");
                        int id = GetConsoleIntValue();
                        WeakestLink weakestLink = new WeakestLink(capacity, id);
                        weakestLink.Run();
                        break;
                    case 2:
                        break;
                    default:
                        Console.WriteLine("Try Again!");
                        break;
                }
            } while (input != 2);
        }
        public static int GetConsoleIntValue()
        {
            Boolean isNegative = true;
            while (isNegative)
            {
                string value = Console.ReadLine();
                int result = 0;
                if (!int.TryParse(value, out result) || result <= 0)
                {
                    Console.WriteLine("Ошибка ввода! Введите корректное значение");
                }
                else
                {
                    isNegative = false;
                    return result;
                }
            }
            return 0;
        }
    }
}
