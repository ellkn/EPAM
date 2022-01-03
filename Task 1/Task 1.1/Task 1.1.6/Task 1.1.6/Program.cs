using System;

namespace Task_1._1._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            fontAdjustment();
        }
        public static void fontAdjustment()
        {
            var currentFont = new Font();
            byte input;
            do
            {
                Console.WriteLine($"Параметры надписи: {currentFont}");
                Console.WriteLine("Введите: ");
                Console.WriteLine("\t1: Bold");
                Console.WriteLine("\t2: Italic");
                Console.WriteLine("\t3: Underline");
                Console.WriteLine("\t0: exit");
                input = GetConsoleByteValue();
                if (currentFont.HasFlag((Font)Math.Pow(2, input - 1)))
                {
                    currentFont ^= (Font)Math.Pow(2, input - 1);
                }                    
                else
                    currentFont ^= (Font)Math.Pow(2, input - 1);
            }
            while (input != 0);
        }
        [Flags]
        enum Font : byte
        {//используем степени 2. отдельные флаги в объединенных константах перечисления не перекрываются
            None = 0,
            Bold = 1,
            Italic = 2,
            Underline = 4
        }

        public static byte GetConsoleByteValue()
        {
            Boolean isNegative = true;
            while (isNegative)
            {
                string value = Console.ReadLine();
                byte result = 0;
                if (!byte.TryParse(value, out result) || result < 0 || result > 3)
                {
                    Console.WriteLine("Ошибка ввода! Введите положительное значение");
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
