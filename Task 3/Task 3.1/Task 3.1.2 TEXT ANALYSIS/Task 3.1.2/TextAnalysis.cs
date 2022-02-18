using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._1._2
{
    public class TextAnalysis
    {
        private static Dictionary<string, int> uniqueWords = new Dictionary<string, int>(); 
        public static void ReadFromConsole()
        {
            Console.WriteLine("Input your text: ");
            String text = RemoveSymbols(GetConsoleStringValue());
            Console.WriteLine(Environment. NewLine + "We did a little analysis and got the following results: "+ Environment.NewLine);
            Analysis(text);
        }
        
        public static void ReadFromFile()
        {
            StreamReader reader = File.OpenText("text.txt");
            try
            {
                string text = reader.ReadToEnd();
                text = RemoveSymbols(text);
                Analysis(text);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if(reader != null)
                {
                    reader.Close();
                }
            }
        }

        public static string RemoveSymbols(string text)
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
        public static void Analysis(string text)
        {
            if (uniqueWords != null)
            {
                uniqueWords.Clear();
            }
            string[] arrayOfWords = text.ToLower().Trim(' ').Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach(var item in arrayOfWords)
            {
                if (uniqueWords.ContainsKey(item))
                {
                    uniqueWords[item]++;
                }
                else
                {
                    uniqueWords.Add(item, 1);
                }
            }
            var sortedDictionary = uniqueWords.OrderByDescending(pair => pair.Value);
            foreach (var item in sortedDictionary)
            {
                double wordFrequency = (double)item.Value / arrayOfWords.Length * 100;
                Console.Write("The word - ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(item.Key);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\t- appears in the text - ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(item.Value);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" - times, which is ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(String.Format("{0:f3}", wordFrequency));
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" percent of all words");
            }
            Console.WriteLine(Environment.NewLine + $"Most often you used the word - {sortedDictionary.First().Key} - {sortedDictionary.First().Value} times");
            
        }
        public static string GetConsoleStringValue()
        {
            Boolean isNegative = true;
            while (isNegative)
            {
                string value = Console.ReadLine();
                if (String.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Input error! Please enter the correct value");
                }
                else
                {
                    isNegative = false;
                    return value;
                }
            }
            return null;
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
                    Console.WriteLine("Input error! Please enter the correct value");
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
