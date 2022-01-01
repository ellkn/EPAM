using System;

namespace Task_1._1._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            nonNegativeSum();
        }
        public static void nonNegativeSum()
        {
            Console.WriteLine("Введите размер одномерного массива: ");
            int n = GetConsoleIntValue();
            int[] array = new int[n];
            Random random = new Random();
            Console.WriteLine("Введите минимальную границу разброса массива: ");
            int minValue = GetConsoleIntValue();
            Console.WriteLine("Введите максимальную границу разброса массива: ");
            int maxValue = GetConsoleIntValue();
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(minValue, maxValue);
            }
            Console.WriteLine("Исходный массив: ");
            printArray(array);
            sumArray(array);
        }
        public static void printArray(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                Console.Write(array[i] + ", ");
            }
            for (int i = array.Length - 1; i < array.Length; i++)
            {
                Console.WriteLine(array[i] + ".");
            }
        }
        public static void sumArray(int[] array)
        {
            int sum = 0;
            for (int i = 0;i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    sum += array[i];
                }
            }
            // вариант 2 - можно использовать foreach
            /*foreach (var i in array)
            {
                if (i > 0)
                {
                    sum += i;
                }  
            }*/
            Console.WriteLine($"Сумма неотрицательных элементов массива = {sum}");
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
