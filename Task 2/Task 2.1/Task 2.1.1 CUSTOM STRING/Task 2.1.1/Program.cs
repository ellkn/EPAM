using System;
using CustomString;

namespace CustomString
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            int input;
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("\t1.  Сравнение массивов");
                Console.WriteLine("\t2.  Конкатенация массивов");
                Console.WriteLine("\t3.  Поиск символов в массиве");
                Console.WriteLine("\t4.  Конвертация из массива символов");
                Console.WriteLine("\t5.  Конвертация в массив символов");
                Console.WriteLine("\t6.  Добавление элемента в массив");
                Console.WriteLine("\t7.  Получение подстроки массива");
                Console.WriteLine("\t8.  Удаление символов из массива");
                Console.WriteLine("\t9.  Работа индексатора");
                Console.WriteLine("\t10. Обратный вывод массива");
                Console.WriteLine("\t0.  Выход");
                Console.ResetColor();
                input = GetConsoleIntValue();
                char[] defaultChar = { 'H', 'e', 'l', 'l', 'o', ',', ' ', 'w', 'o', 'r', 'l', 'd', '!' };
                string defaultString = "Default String";
                CustomString customString = new CustomString(defaultChar);
                switch (input)
                {
                    case 0:
                        break;
                    case 1:
                        Console.WriteLine("Введите первое предложение:");
                        char[] first = GetConsoleCharArrayValue();
                        Console.WriteLine("Введите второе предложение:");
                        char[] second = GetConsoleCharArrayValue();
                        CustomString firstStr = new CustomString(first);
                        CustomString secondStr = new CustomString(second);
                        Console.WriteLine("Результат: " + CustomString.Comparison(firstStr, secondStr));
                        break;
                    case 2:
                        Console.WriteLine("Введите количество соединяемых фрагментов:");
                        int n = GetConsoleIntValue();
                        Console.WriteLine(CustomString.Concatenation(n));
                        
                        //второй способ - перегрузка операторра
                        Console.WriteLine("\tИспользование перегрузки оператора +" );
                        Console.WriteLine("Введите первое предложение:");
                        char[] str1 = GetConsoleCharArrayValue();
                        Console.WriteLine("Введите второе предложение:");
                        char[] str2 = GetConsoleCharArrayValue();
                        CustomString strStr1 = new CustomString(str1);
                        CustomString strStr2 = new CustomString(str2);
                        CustomString newString = strStr1 + strStr2;
                        Console.WriteLine("Результат " + newString);
                        break;
                    case 3:
                        Console.WriteLine("Введите предложение, в котором хотите найти символ:");
                        char[] text = GetConsoleCharArrayValue();
                        CustomString textStr1 = new CustomString(text);
                        Console.WriteLine("Введите символ, который хотите найти: ");
                        char[] symbol = GetConsoleCharArrayValue();
                        Console.WriteLine("Поиск будет произведен по первому введенному символу");
                        textStr1.SearchChar(symbol);
                        break;
                    case 4:
                        Console.WriteLine("Исходный массив символов: " + customString);
                        Console.WriteLine("GetType: " + customString.CstmString.GetType());
                        string convertedString = customString.ConvertToString();
                        Console.WriteLine("Конвертированная строка: " + convertedString);
                        Console.WriteLine("GetType: " + convertedString.GetType());
                        break;
                    case 5:
                        Console.WriteLine("Исходная строка: " + defaultString);
                        Console.WriteLine("GetType: " + defaultString.GetType());
                        char[] convertedChar = defaultString.ToCharArray(); // не уверена, что правильно использовать toCharArray()
                        customString = new CustomString(convertedChar);
                        Console.WriteLine("Конвертированный массив:" + string.Join('|', convertedChar));
                        Console.WriteLine("GetType: " + customString.CstmString.GetType());
                        break;
                    case 6:
                        Console.WriteLine("Исходный массив символов: " + customString);
                        Console.WriteLine("Введите индекс вставки: ");
                        int index = GetConsoleIntValue();
                        Console.WriteLine("Введите элемент вставки: (добавиться только элемент с идексом 0)");
                        char[] symbols = GetConsoleCharArrayValue();
                        customString = customString.Insert(index, symbols);
                        Console.WriteLine("Итоговый массив символов: " + customString);
                        break;
                    case 7:
                        Console.WriteLine("Исходный массив символов: " + customString);
                        Console.WriteLine("Введите начальный индекс для вывода подстроки: ");
                        int startIndex = GetConsoleIntValue();
                        Console.WriteLine("Введите длину подстроки: ");
                        int length = GetConsoleIntValue();
                        customString = customString.Substring(startIndex, length);
                        Console.WriteLine("Итоговый массив символов: " + customString);
                        break;
                    case 8:
                        Console.WriteLine("Исходный массив символов: " + customString);
                        Console.WriteLine("Введите индекс символа, который хотите удалить: ");
                        int sIndex = GetConsoleIntValue();
                        customString = customString.Delete(sIndex);
                        Console.WriteLine("Итоговый массив символов: " + customString);
                        break;
                    case 9:
                        Console.WriteLine("Исходный массив символов: " + customString);
                        Console.WriteLine("Введите индекс, который хотите вывести: ");
                        int indexEl = GetConsoleIntValue();
                        Console.WriteLine($"Элемент с индексом {indexEl}: " + customString[indexEl]);
                        break;
                    case 10:
                        Console.WriteLine("Исходный массив символов: " + customString);
                        customString = customString.Inversion();
                        break;
                    default:
                        Console.WriteLine("Попробуйте еще раз!");
                        break;
                }

            } while (input != 0);

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
        public static char[] GetConsoleCharArrayValue()
        {
            Boolean isNegative = true;
            while (isNegative)
            {
               string value = Console.ReadLine();
               char[] result = null;
                if (String.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Ошибка ввода! Введите корректное значение");
                }
                else
                {
                    isNegative = false;
                    return result = value.ToCharArray();
                }
            }
            return null;
        }
    }
}
