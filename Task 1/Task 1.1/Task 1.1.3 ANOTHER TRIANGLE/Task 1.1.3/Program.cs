using System;

namespace Task_1._1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число N: ");
            AnotherTriangle();
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
        public static void AnotherTriangle()
        {
            int n = GetConsoleIntValue();
            for(int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                    Console.Write(" ");
                for (int r = 1; r <= i; r++)
                    Console.Write("*");
                for (int l = i - 1; l >= 1; l--)
                    Console.Write("*");
                Console.WriteLine();
            }
        }
    }
}
