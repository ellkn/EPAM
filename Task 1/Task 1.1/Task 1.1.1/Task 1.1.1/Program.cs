using System;

namespace Task_1._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rectangle - программа, позволяющая высчитывать значение площади прямоугольника");
            double a, b; // переменные для ввода значений. а - длина, b - ширина
                         //знаю, в задании написано игнорировать ввод нецелых чисел, но пусть такая возможность тоже будет

            // ВАРИАНТ 1. 

            /*bool cyrcle=true;
            while (cyrcle)
            {
                Console.WriteLine("Введите значение длины а: ");
                while (!double.TryParse(Console.ReadLine(), out a))
                {
                    Console.WriteLine("Ошибка ввода! Введите положительное значение длины a");
                }
                Console.WriteLine("Введите значение ширины b: ");
                while (!double.TryParse(Console.ReadLine(), out b))
                {
                    Console.WriteLine("Ошибка ввода! Введите положительное значение ширины b");
                }
                if (a > 0 && b > 0)
                {
                    Console.WriteLine("Площадь прямоугольника = " + Rectangle(a, b));
                    cyrcle = false;
                }
                else
                {
                    Console.WriteLine("Введенные значения не соответствуют требованиям. Попробуйте еще раз");
                    if (a < 0 || a == 0)
                        Console.WriteLine("Ошибка в a");
                    if (b < 0 || b == 0)
                        Console.WriteLine("Ошибка в b");
                }
            }*/

            // ВАРИАНТ 2. 
            
            Console.WriteLine("Введите значение длины а: ");
            a = GetConsoleDoubleValue();
            Console.WriteLine(a);
            Console.WriteLine("Введите значение ширины b: ");
            b = GetConsoleDoubleValue();
            Console.WriteLine("Площадь прямоугольника = " + Rectangle(a, b));
        }
        public static double GetConsoleDoubleValue()
        {
            Boolean isNegative = true;
            while(isNegative)
            {
                string value = Console.ReadLine();
                double result = 0;
                if (!double.TryParse(value, out result) || result < 0)
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
        static double Rectangle(double a, double b) => a * b; 
    }
}
