using System;
using System.Text;

namespace Task_1._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            averages();
        }
        public static void averages()
        {
            int wordCount = 0;
            double letters = 0;
            Console.WriteLine("Введите предложение: ");
            String text = removeSymbols(Console.ReadLine());
            string[] array = text.Trim(' ').Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
                wordCount++;
                letters +=array[i].Length;
            }
            double result = letters / wordCount;
            Console.WriteLine($"Количество букв                             :\t{letters}");
            Console.WriteLine($"Количество слов                             :\t{wordCount}");
            Console.WriteLine($"Средняя длина слов (без округления)         :\t{result}");
            Console.WriteLine($"Средняя длина слов (с округлением до сотен ):\t{String.Format("{0:f}", result)}");
            Console.WriteLine($"Средняя длина слов (с округлением до целого):\t{String.Format("{0:f0}", result)}");
        }
        public static string removeSymbols(string text)
        {
            var someString = new StringBuilder(text);
            for(int i = 0;i < someString.Length; i++)
            {
                if (char.IsNumber(someString[i]) || char.IsPunctuation(someString[i]))
                {
                    someString.Replace(someString[i], ' ');
                }
            }
            return someString.ToString();
        }
    }
}
