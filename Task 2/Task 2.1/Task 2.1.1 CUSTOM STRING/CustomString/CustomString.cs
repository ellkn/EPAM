using System;

namespace CustomString
{
    public class CustomString
    {
        private char[] _customString;
        public char[] CstmString
        {
            get { return _customString; }
            set { _customString = value; }
        }
        public int Length
        {
            get { return _customString.Length; }
        }
        //конструкторы
        public CustomString()
        {
            _customString = new char[16];
        }
        public CustomString(char[] _customString)
        {
            this._customString = _customString;
        }
        //Сравнение массивов
        public static bool Comparison(CustomString first, CustomString second)
        {
            if (first._customString.Length != second._customString.Length)
            {
                return false;
            }
            for (int i = 0; i < first._customString.Length; i++)
            {
                if (first._customString[i] != second._customString[i])
                    return false;
            }
            return true;
        }
        //Конкатинация массивов
        public static CustomString Concatenation(int n)
        {
            string[] values = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введите предложение " + i + ":");
                values[i] = Console.ReadLine().Trim();
            }
            string itog = string.Join(" ", values);
            char[] result = itog.ToCharArray();
            Console.WriteLine("Результат:");
            return new CustomString(result);
        }
        //Конкатинация методом перегрузки оператора
        public static CustomString operator +(CustomString str1, CustomString str2)
        {
            string newString = new string(str1._customString) + new string(str2._customString);
            char[] result = newString.ToCharArray();
            return new CustomString(result);
        }
        // Поиск символа в массиве (если введено несколько символов, то ищет вхождение первого введенного символа)
        public bool FindChar(char[] symbol)
        {
            for (int i = 0; i < _customString.Length; i++)
            {
                if (_customString[i] == symbol[0])
                {
                    Console.Write("Введенный элемент найден в позиции(ях): ");
                    return true;
                }
            }
            Console.WriteLine("Введенный элемент не найден");
            return false;
        }
        //определение наличия символа в массиве
        public char[] SearchChar(char[] symbol)
        {
            if (FindChar(symbol) == true)
            {
                for (int i = 0; i < _customString.Length; i++)
                {
                    if (_customString[i] == symbol[0])
                    {
                        Console.Write(i + " ");
                    }
                }
                Console.WriteLine();
            }
            return _customString;
        }
        //конвертация в массив символов
        public char[] ConvertToCharArray()
        {
            char[] convertedChar = new char[_customString.Length];

            for (int i = 0; i < _customString.Length; i++)
            {
                convertedChar[i] = _customString[i];
            }
            return convertedChar;
        }
        //конвертация из массива символов
        public string ConvertToString()
        {
            return new string(_customString);
        }
        // Добавление подстроки в массив 
        public CustomString Insert(int index, char[] symbol)
        {
            char[] array = new char[_customString.Length + 1];
            if (index < _customString.Length)
            {
                int currentIndex = 0;
                for (int i = 0; i < array.Length; i++, currentIndex++)
                {
                    if (index == i)
                    {
                        array[i] = symbol[0];
                        currentIndex = currentIndex - 1;
                    }
                    else
                    {
                        array[i] = _customString[currentIndex];
                    }
                }
                return new CustomString(array);
            }
            else Console.WriteLine("Введен неверный индекс - попробуйте еще раз!");
            return null;
        }
        // получение подстроки массива
        public CustomString Substring(int index, int length)
        {
            char[] array = new char[length];
            if ((index + length) > _customString.Length)
            {
                Console.WriteLine("Введен неверный индекс - попробуйте еще раз!");
            }
            else
            {
                for (int i = 0; i < length; i++)
                {
                    array[i] = _customString[index];
                    index++;
                }
            }
            return new CustomString(array);
        }
        // Удаление символов
        public CustomString Delete(int index)
        {
            char[] array = new char[_customString.Length - 1];
            if (index > _customString.Length)
            {
                Console.WriteLine("Введен неверный индекс - попробуйте еще раз!");
            }
            else
            {
                int currentIndex = 0;
                for (int i = 0; i < array.Length; i++, currentIndex++)
                {
                    if (index == i)
                    {
                        ++currentIndex;
                        array[i] = _customString[currentIndex];
                    }
                    else
                    {
                        array[i] = _customString[currentIndex];
                    }
                }
            }
            return new CustomString(array);
        }
        // индексатор
        public char this[int index]
        {
            get
            {
                if (index > 0 && index < _customString.Length)
                    return _customString[index];
                else
                    Console.WriteLine("Неверный индекс строки");
                return '\0';
            }
            set
            {
                if (index > 0 && index < _customString.Length)
                    _customString[index] = value;
                else
                    Console.WriteLine("Неверный индекс строки");
            }
        }
        //обратный вывод массива
        public CustomString Inversion()
        {
            Console.Write("Обратный вывод массива  : ");
            for (int i = _customString.Length - 1; i >= 0; i--)
            {
                Console.Write(_customString[i]);
            }
            Console.WriteLine();
            return new CustomString(_customString);
        }
        //переопределение вывода toString()
        public override string ToString()
        {
            return new string(_customString);
        }
    }
}
