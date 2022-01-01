using System;
using System.Text;

namespace Task_1._2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            validator();
        }
        public static void validator()
        {
            bool newSentence = true;
            Console.WriteLine("Введите предложение: ");
            String text = Console.ReadLine();
            var stringBuilder = new StringBuilder(text);
            for (int i = 0; i < stringBuilder.Length; i++)
            {
                if(newSentence == true && stringBuilder[i] != ' ')
                {
                    if (char.IsLower(stringBuilder[i]))
                    {
                        stringBuilder[i] = char.ToUpper(stringBuilder[i]);
                    }
                    newSentence = false;
                }
                if (stringBuilder[i] == '.' || stringBuilder[i] == '?' || stringBuilder[i] == '!')
                {
                    newSentence = true;
                }
            }
            Console.WriteLine($"Измененное предложение: {stringBuilder}");
        }
    }
}
