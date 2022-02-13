using System;
using System.Collections.Generic;

namespace Task_3._3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pizzaria pizzaria = new Pizzaria();
            bool isOpenApplication = true;
            while (isOpenApplication)
            {
                Console.Write("Введите Ваш никнейм: ");
                string name = Console.ReadLine();
                User user = new User(name);
                Dictionary<PizzaType, int> pizzasList = new();
                bool isOpenBasket = true;
                while (isOpenBasket)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Выберите пиццу:");
                    Console.WriteLine($"1. Маргарита - {Pizza.MARGARITA_PRICE} рублей");
                    Console.WriteLine($"2. 4 сезона - {Pizza.FOUR_SEASONS_PRICE} рублей");
                    Console.WriteLine($"3. Пепперони - {Pizza.PEPPERONI_PRICE} рублей");
                    Console.WriteLine($"4. Классическая - {Pizza.CLASSIC_PRICE} рублей");
                    Console.WriteLine($"5. Ассорти - {Pizza.ASSORTED_PRICE} рублей");
                    Console.WriteLine($"0. Завершить выбор и сделать заказ");
                    Console.ForegroundColor = ConsoleColor.White;
                    int value = GetConsoleIntValue();
                    switch (value)
                    {
                        case 0:
                            if (pizzasList.Count != 0)
                            {
                                isOpenBasket = false;
                            }
                            else 
                            {
                                Console.WriteLine("Вы не выбрали ни одной пиццы, хотите закончить заказ?");
                                Console.WriteLine("1. Да. \t2. Вернуться и сделать заказ");
                                int exitValue = GetConsoleIntValue();
                                switch (exitValue)
                                {
                                    case 1:
                                        isOpenBasket = false;
                                        break;
                                    case 2:
                                        break;
                                    default:
                                        Console.WriteLine("Поробуйте еще раз!");
                                        break;
                                }
                            }
                            break;
                        case 1:
                            AddOrIncrement(pizzasList, PizzaType.Margarita);
                            break;
                        case 2:
                            AddOrIncrement(pizzasList, PizzaType.FourSeasons);
                            break;
                        case 3:
                            AddOrIncrement(pizzasList, PizzaType.Pepperoni);
                            break;
                        case 4:
                            AddOrIncrement(pizzasList, PizzaType.Classic);
                            break;
                        case 5:
                            AddOrIncrement(pizzasList, PizzaType.Assorted);
                            break;
                    }
                }
                Console.WriteLine("Your order is: ");
                foreach (var item in pizzasList)
                {
                    Console.WriteLine($"{item}");
                } 
                user.OrderPizza(pizzaria, pizzasList);
                               
            }
        }

        public static void AddOrIncrement(Dictionary<PizzaType, int> pizzasList,PizzaType pizzaType)
        {
            if (pizzasList.Count == 0 || !pizzasList.ContainsKey(pizzaType))
            {
                pizzasList.Add(pizzaType, 1);
            }
            else if (pizzasList.ContainsKey(pizzaType))
            {
                pizzasList[pizzaType] += 1;
            }
        }
        public static int GetConsoleIntValue()
        {
            Boolean isNegative = true;
            while (isNegative)
            {
                string value = Console.ReadLine();
                int result = 0;
                if (!int.TryParse(value, out result) || result < 0 || result > 5)
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