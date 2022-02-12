using System;

namespace Task_3._3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Input your text: ");
                string someText = Console.ReadLine();
                Console.WriteLine($"Your Language type is {someText.CheckLanguages()}");
                Console.WriteLine();
            }
            while (true);
        }
    }
}
