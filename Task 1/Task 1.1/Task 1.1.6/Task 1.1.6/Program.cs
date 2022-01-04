using System;

namespace Task_1._1._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //fontAdjustment(); // первый способ
            fontAdjustmentSecond();// второй способ
        }
        // первый способ
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
        //второй способ
        public static void fontAdjustmentSecond()
        {
            bool[] font = { false, false, false, };
            String FontStyle = "";
            
            int input;
            do
            {
                if (font[0] == true)
                    FontStyle += "Bold, ";
                if (font[1] == true)
                    FontStyle += "Italic, ";
                if (font[2] == true)
                    FontStyle += "Underline.";
                if (FontStyle == "")
                    FontStyle = "None";

                Console.WriteLine($"Параметры надписи: {FontStyle}");
                if (FontStyle.Length > 0)
                    FontStyle = FontStyle.Remove(0);
                Console.WriteLine("Введите: ");
                Console.WriteLine("\t1: Bold");
                Console.WriteLine("\t2: Italic");
                Console.WriteLine("\t3: Underline");
                Console.WriteLine("\t0: exit");

                input = GetConsoleIntValue();
                switch (input)
                {
                    case 0:
                        break;
                    case 1:
                        font[0] = !font[0];
                        break;
                    case 2:
                        font[1] = !font[1];
                        break;
                    case 3:
                        font[2] = !font[2];
                        break;
                }
            }
            while (input != 0);
        }
        public static int GetConsoleIntValue()
        {
            Boolean isNegative = true;
            while (isNegative)
            {
                string value = Console.ReadLine();
                int result = 0;
                if (!int.TryParse(value, out result) || result < 0 || result > 3)
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
