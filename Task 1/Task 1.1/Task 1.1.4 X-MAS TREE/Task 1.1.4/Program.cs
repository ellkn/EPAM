using System;

namespace Task_1._1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество треугольников: ");
            xmasTree();
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
        public static void xmasTree()
        {
            int n = GetConsoleIntValue();
            for (int i = 1; i <= n; i++)
            {
                for (var j = 1; j <= i; j++)
                {
                    Console.WriteLine(new string(' ', n - j) + new string('*', j * 2 - 1));
                }
            }
        }
    }
}
