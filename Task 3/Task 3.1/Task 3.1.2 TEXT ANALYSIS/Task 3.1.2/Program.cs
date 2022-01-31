using System;

namespace Task_3._1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Input your name: ");
            name = TextAnalysis.GetConsoleStringValue();
            Console.Clear();
            Console.WriteLine($"Welcome, Dear {name}!");
            Console.ForegroundColor = ConsoleColor.White;
            int input;
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Select an action: ");
                Console.WriteLine("\t1. Enter the text yourself");
                Console.WriteLine("\t2. Work with a written text file");
                Console.WriteLine("\t0. Exiting the program");
                Console.ForegroundColor = ConsoleColor.White;
                input = TextAnalysis.GetConsoleIntValue();
                switch (input)
                {
                    case 0:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine($"See you soon, Dear {name}!");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case 1:
                        TextAnalysis.ReadFromConsole();
                        break;
                    case 2:
                        TextAnalysis.ReadFromFile();
                        break;
                    default:
                        Console.WriteLine("Please, try again!");
                        break;
                }
            }while(input !=0);
                        

        }
    }
}
