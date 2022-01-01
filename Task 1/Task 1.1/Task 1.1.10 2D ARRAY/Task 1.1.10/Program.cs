using System;

namespace Task_1._1._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            twoDArray();
        }
        public static void twoDArray()
        {
            Console.WriteLine("Введите размер двумерного массива: ");
            Console.WriteLine("n: ");
            int n = GetConsoleIntValue();
            Console.WriteLine("m: ");
            int m = GetConsoleIntValue();
            int[,] array = new int[n, m];
            Random random = new Random();
            Console.WriteLine("Введите минимальную границу разброса массива: ");
            int minValue = GetConsoleIntValue();
            Console.WriteLine("Введите максимальную границу разброса массива: ");
            int maxValue = GetConsoleIntValue();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = random.Next(minValue, maxValue);
                }
            }
            Console.WriteLine("Исходный массив: ");
            printArray(array);
            PSum(array);
        }
        public static void printArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public static void PSum(int[,] array)
        {
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if ((i + j) % 2 == 0) sum += array[i, j];
                }
            }
            Console.WriteLine($"Сумма элементов массива стоящих на чётных позициях {sum}");
        }
        public static int GetConsoleIntValue()
        {
            Boolean isNegative = true;
            while (isNegative)
            {
                string value = Console.ReadLine();
                int result = 0;
                if (!int.TryParse(value, out result))
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
