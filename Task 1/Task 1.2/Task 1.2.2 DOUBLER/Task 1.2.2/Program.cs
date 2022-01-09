using System;

namespace Task_1._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Doubler();
        }
        public static void Doubler()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Введите исходное предложение: ");
            Console.ResetColor();
            string inputTextOne = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Введите предложение, содержащее дублируемые буквы: ");
            Console.ResetColor();
            string inputTextTwo = Console.ReadLine();
            string outputText = "";
            foreach (char i in inputTextOne)
                if (inputTextTwo.Contains(i))
                {
                    outputText += i;
                    outputText += i;
                }
                else
                {
                    outputText += i;
                }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Полученное предложение: ");
            Console.ResetColor();
            Console.WriteLine(outputText);
        }
    }
}
