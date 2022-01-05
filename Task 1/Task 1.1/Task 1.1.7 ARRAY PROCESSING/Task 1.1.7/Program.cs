using System;

namespace Task_1._1._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input;
            do 
            {
                Console.WriteLine("Введите n-мерность массива: ");
                Console.WriteLine("\t1. Одномерный массив");
                Console.WriteLine("\t2. Двумерный массив");
                Console.WriteLine("\t3. Выход");
                
                input = GetConsoleIntValue();
                switch (input)
                {
                    case 1:
                        arrayProcessing();
                        break;
                    case 2:
                        secondArrayProcessing();
                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("Попробуйте еще раз!");
                        break;
                }
            } while (input != 3);
        }
        // РАБОТА С ОДНОМЕРНЫМ МАССИВОМ
        public static void arrayProcessing()
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
            Console.WriteLine("Отсортированный массив: ");
            sortArray(array);
            printArray(array);
            getMaxValue(array);
            getMinValue(array);
            Console.WriteLine();
        }
        public static void printArray(int[] array)
        {
            for (int i = 0;i < array.Length - 1; i++)
            {
                Console.Write(array[i]+ ", ");
            }
            for (int i = array.Length - 1; i < array.Length; i++ )
            {
                Console.WriteLine(array[i] + ".");
            }
        }
        public static void sortArray(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
        public static void getMaxValue(int[] array)
        {
            int max = array[0];
            for(int i=0; i < array.Length; i++)
            {
                if(max < array[i])
                {
                    max = array[i];
                }
            }
            Console.WriteLine($"Максимальное значение массива: {max}");
        }
        public static void getMinValue(int[] array)
        {
            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                }
            }
            Console.WriteLine($"Минимальное значение массива: {min}");
        }

        //РАБОТА С ДВУМЕРНЫМ МАССИВОМ
        public static void secondArrayProcessing()
        {
            Console.WriteLine("Введите размер двумерного массива: ");
            Console.WriteLine("n: ");
            int n = GetConsoleIntValue();
            Console.WriteLine("m: ");
            int m = GetConsoleIntValue();
            int[ , ] array = new int[n, m];
            Random random = new Random();
            Console.WriteLine("Введите минимальную границу разброса массива: ");
            int minValue = GetConsoleIntValue();
            Console.WriteLine("Введите максимальную границу разброса массива: ");
            int maxValue = GetConsoleIntValue();
            for (int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    array[i, j] = random.Next(minValue, maxValue);
                }
            }
            Console.WriteLine("Исходный массив: ");
            printArray(array);
            sortrowArray(array);
            sortcolumnArray(array);
            getMaxValue(array);
            getMinValue(array);
            Console.WriteLine();
        }
        public static void printArray(int[,] array)
        {
            for(int i = 0; i < array.GetLength(0); i++)
            {
                for( int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public static void sortrowArray(int[,] array)
        {
            Console.WriteLine("Отсортированный по строкам массив: ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = array.GetLength(1) - 1; j > 0; j--)
                {
                    for (int k = 0; k < j; k++)
                    {
                        if (array[i, k] > array[i, k + 1])
                        {
                            int temp = array[i, k];
                            array[i, k] = array[i, k + 1];
                            array[i, k + 1] = temp;
                        }
                    }
                }
            }
            printArray(array);
        }
        public static void sortcolumnArray(int[,] array)
        {
            /*Console.WriteLine("Отсортированный по столбцам массив: ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                }
            }
            printArray(array);*/
        }
        public static void getMaxValue(int[,] array)
        {
            int max = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (max < array[i, j])
                    {
                        max = array[i, j];
                    }
                }
            }
            Console.WriteLine($"Максимальное значение массива: {max}");
        }
        public static void getMinValue(int[,] array)
        {
            int min = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (min > array[i, j])
                    {
                        min = array[i, j];
                    }
                }
            }
            Console.WriteLine($"Минимальное значение массива: {min}");
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
