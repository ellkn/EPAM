using System;

namespace Task1._1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число N: ");
            Triangle();
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
        static void Triangle()
        {
            int n = GetConsoleIntValue();
            for (var i = "*"; i.Length <= n; i += "*")
            {
                Console.WriteLine(i);
            }
                
        }
    }
}
