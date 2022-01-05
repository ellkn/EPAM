using System;

namespace Task_1._1._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            noPositive();
        }
        public static void noPositive()
        {
            Console.WriteLine("Введите размер трехмерного массива: ");
            Console.WriteLine("x: ");//количество блоков
            int x = GetConsoleIntValue();
            Console.WriteLine("y: ");//количество строк
            int y = GetConsoleIntValue();
            Console.WriteLine("z: "); //количество столбцов
            int z = GetConsoleIntValue();
            int[,,] array = new int[x, y, z];
            Random random = new Random();
            Console.WriteLine("Введите минимальную границу разброса массива: ");
            int minValue = GetConsoleIntValue();
            Console.WriteLine("Введите максимальную границу разброса массива: ");
            int maxValue = GetConsoleIntValue();
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    for (int k = 0; k< z; k++)
                    {
                        array[i, j, k] = random.Next(minValue, maxValue);
                    }
                }
            }
            Console.WriteLine("Исходный трехмерный массив: ");
            printArray(array);
            Console.WriteLine("Измененный трехмерный массив: ");
            zero(array);
            printArray(array);
        }
        public static void printArray(int[,,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine($"Массив #{i + 1}: ");
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        Console.Write(array[i, j, k] + " ");
                    }
                    Console.WriteLine("\t");
                }
                Console.WriteLine("\t");
            }
        }
        public static void zero(int[,,] array)
        {
            for (var i = 0; i < array.GetLength(0); i++)
            {
                for (var j = 0; j < array.GetLength(1); j++) 
                {
                    for (var k = 0; k < array.GetLength(2); k++)
                    {
                        if (array[i, j, k] > 0)
                        {
                            array[i, j, k] = 0;
                        }
                    }
                }
            }
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
