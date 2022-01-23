using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2._1._2.Abstract;
using Task_2._1._2.Figures;

namespace Task_2._1._2.Logic
{
    public class ActionHandler
    {
        Dictionary<User, List<Model>> figuresByUser = new Dictionary<User, List<Model>>();
        public ActionHandler(User user)
        {
            figuresByUser.Add(user, new List<Model>());
        }
        public static void PrintMenu()
        {
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("\t1. Добавить фигуру");
            Console.WriteLine("\t2. Вывести все фигуры");
            Console.WriteLine("\t3. Очистить холст");
            Console.WriteLine("\t4. Сменить пользователя");
            Console.WriteLine("\t0. Выход");
        }
        public void AddFigure(User user)
        {
            int currentFigure;
            bool isChoosing = true;
            while (isChoosing)
            {
                Console.WriteLine("Выберите фигуру:");
                Console.WriteLine("\t1. Точка");
                Console.WriteLine("\t2. Линия");
                Console.WriteLine("\t3. Окружность");
                Console.WriteLine("\t4. Круг");
                Console.WriteLine("\t5. Кольцо");
                Console.WriteLine("\t6. Треугольник");
                Console.WriteLine("\t7. Квадрат");
                Console.WriteLine("\t8. Прямоугольник");
                isChoosing = false;
                currentFigure = GetConsoleIntValue();
                switch (currentFigure)
                {
                    case 1:
                        figuresByUser[user].Add(CreatePoint());
                        break;
                    case 2:
                        figuresByUser[user].Add(CreateLine());
                        break;
                    case 3:
                        figuresByUser[user].Add(CreateRound());
                        break;
                    case 4:
                        figuresByUser[user].Add(CreateCircle());
                        break;
                    case 5:
                        figuresByUser[user].Add(CreateRing());
                        break;
                    case 6:
                        figuresByUser[user].Add(CreateTriangle());
                        break;
                    case 7:
                        figuresByUser[user].Add(CreateSquare());
                        break;
                    case 8:
                        figuresByUser[user].Add(CreateRectangle());
                        break;
                    default:
                        Console.WriteLine("Try Again");
                        isChoosing = true;
                        break;

                }
            }
        }
        public void ShowAllFigures(User user)
        {
            foreach (var figure in figuresByUser[user])
            {
                Console.WriteLine(figure.Name + " - " + figure.Properties);
            }
        }
        public void DeleteAllFigures(User user)
        {
            figuresByUser[user].Clear();
        }
        public void AddUser()
        {
            Console.WriteLine("Введите имя пользователя:");
            string name = GetConsoleStringValue();
            User user = new User() { Name = name}; //имена должны быть уникальными
            if (!figuresByUser.Keys.Contains(user))
            {
                figuresByUser.Add(user, new List<Model>());
            } 
            else
            {
                Console.WriteLine("Пользователь с таким именем уже существует! Попробуйте еще раз!");
            }
        }
        public User ChangeUser()
        {
            Console.WriteLine("Список пользователей: ");
            var users = figuresByUser.Keys.ToArray();
            for (int i = 0; i < users.Length; i++)
            {
                Console.WriteLine($"{i+1} : {users[i]}");
            }
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("\t1. Добавить пользователя");
            Console.WriteLine("\t2. Выбрать пользователя из существующего списка");
            Console.WriteLine("\t3. Выход");
            int input = GetConsoleIntValue();
            switch (input)
            {
                case 1:
                    AddUser();
                    break;
                case 2:
                    int userNumber = 0;
                    while (true)
                    {
                        Console.WriteLine("Введите номер пользователя:");
                        userNumber = GetConsoleIntValue();
                        if (userNumber < users.Length)
                        {
                            return users[userNumber-1];
                        }
                        else
                        {
                            Console.WriteLine("Введено некорректное значение");
                            continue;
                        }
                    }
                    break;
                case 3:
                    break;
                default:
                    Console.WriteLine("Try Again");
                    break;
            }
            return null;
        }
        private Point CreatePoint()
        {
            Console.WriteLine("Введите значение координаты Х: ");
            double x = GetConsoleDoubleValue();
            Console.WriteLine("Введите значение координаты У: ");
            double y = GetConsoleDoubleValue();
            
            return new Point(x, y);
        }
        private Line CreateLine()
        {
            Console.WriteLine("Введите значение первой точки: ");
            Point firstPoint = CreatePoint();
            Console.WriteLine("Введите значение второй точки: ");
            Point secondPoint = CreatePoint();
            return new Line(firstPoint, secondPoint);
        }
        private Round CreateRound()
        {
            Console.WriteLine("Введите точку центра");
            Point center = CreatePoint();
            Console.WriteLine("Введите значение радиуса");
            double radius = GetConsoleDoublePositiveValue();

            return new Round(center, radius);
        }
        private Circle CreateCircle()
        {
            Console.WriteLine("Введите точку центра");
            Point center = CreatePoint();
            Console.WriteLine("Введите значение радиуса");
            double radius = GetConsoleDoublePositiveValue();

            return new Circle(center, radius);
        }
        private Ring CreateRing()
        {
            Console.WriteLine("Введите точку центра");
            Point center = CreatePoint();
            Console.WriteLine("Введите значение врутреннего радиуса");
            double firstRadius = GetConsoleDoublePositiveValue();
            Console.WriteLine("Введите значение внешнего радиуса");
            double secondRadius = GetConsoleDoublePositiveValue();
            // в случае, если пользователь ввел у внутреннего радиуса большее значение, 
            // найдем минимум и максимум 
            return new Ring(center, firstRadius, secondRadius);
        }
        private Triangle CreateTriangle()
        {
            Console.WriteLine("Введите значение первой точки: ");
            Point firstPoint = CreatePoint();
            Console.WriteLine("Введите значение второй точки: ");
            Point secondPoint = CreatePoint();
            Console.WriteLine("Введите значение третьей точки: ");
            Point thirdPoint = CreatePoint();
            return new Triangle(firstPoint, secondPoint, thirdPoint);
        }
        private Square CreateSquare()
        {
            Console.WriteLine("Введите точку центра");
            Point center = CreatePoint();
            Console.WriteLine("Введите значение стороны");
            double side = GetConsoleDoublePositiveValue();
            return new Square(center, side);
        }
        private Rectangle CreateRectangle()
        {
            Console.WriteLine("Введите точку центра");
            Point center = CreatePoint();
            Console.WriteLine("Введите значение длины прямоугольника");
            double firstSide = GetConsoleDoublePositiveValue();
            Console.WriteLine("Введите значение ширины прямоугольника");
            double secondSide = GetConsoleDoublePositiveValue();
            return new Rectangle(center, firstSide, secondSide);
        }

        public static double GetConsoleDoubleValue()
        {
            Boolean isNegative = true;
            while (isNegative)
            {
                string value = Console.ReadLine();
                double result = 0;
                if (!double.TryParse(value, out result))
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
        public static double GetConsoleDoublePositiveValue()
        {
            Boolean isNegative = true;
            while (isNegative)
            {
                string value = Console.ReadLine();
                double result = 0;
                if (!double.TryParse(value, out result) || result < 0)
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
        public static int GetConsoleIntValue()
        {
            Boolean isNegative = true;
            while (isNegative)
            {
                string value = Console.ReadLine();
                int result = 0;
                if (!int.TryParse(value, out result) || result < 0)
                {
                    Console.WriteLine("Ошибка ввода! Введите положительное значение");
                }
                else
                {
                    isNegative = false;
                    return result;
                }
            }
            return 0;
        }
        public static string GetConsoleStringValue()
        {
            Boolean isNegative = true;
            while (isNegative)
            {
                string value = Console.ReadLine();
                if (String.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Ошибка ввода! Введите корректное значение");
                }
                else
                {
                    isNegative = false;
                    return value;
                }
            }
            return null;
        }
    }
}
