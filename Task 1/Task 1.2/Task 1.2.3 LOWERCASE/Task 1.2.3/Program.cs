using System;
using System.Text;

namespace Task_1._2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            lowercase();
        }
        public static void lowercase()
        {
            int wordCount = 0;
            bool check = false;
            Console.WriteLine("Введите предложение: ");
            String text = removeSymbols(Console.ReadLine());
            string[] array = text.Trim(' ').Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < array.Length; i++)
            {
                foreach(char c in array[i])
                {
                    if (!char.IsLower(c))
                    {
                        break;
                    }
                    else
                    {
                        check = true;
                    }
                }
                if (check == true)
                {
                    wordCount++;
                }
                check = false;
            }
            Console.WriteLine($"Количество слов, начинающихся с маленькой буквы: {wordCount}");
        }
        public static string removeSymbols(string text)
        {
            var someString = new StringBuilder(text);
            for (int i = 0; i < someString.Length; i++)
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
