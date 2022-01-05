using System;

namespace Task_1._1._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sumOfNumbers();
        }
        static public void sumOfNumbers()
        {
            int sum = 0;
            int limit = 1000;
            for (int i = 0; i < limit; i++)
                if (i % 3 == 0 || i % 5 == 0)
                    sum += i;
            Console.WriteLine($"Сумма чисел меньше 1000, кратных 3 или 5: {sum}");
        }
    }
}
