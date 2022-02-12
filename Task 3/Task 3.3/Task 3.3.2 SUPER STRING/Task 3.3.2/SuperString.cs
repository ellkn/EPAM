using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._3._2
{
    public static class SuperString
    {
        // проверка языка в строке: русский, английский, числовой, смешанный
        // если совокупноть - то к миксу
        // если есть пробелы, знаки препинания, тоже к последней категории
        // слово - любой набор символов
        public static Languages CheckLanguages(this string someText)
        {
            if(someText == null)
            {
                return Languages.None;
            }

            if (char.IsNumber(someText[0]))
            {
                if(someText.Any(x => !char.IsDigit(x)))
                {
                    return Languages.Mixed;
                }
                return Languages.Number;
            }
            if (char.IsLetter(someText[0]))
            {
                if(someText.Any(x => !char.IsLetter(x)))
                {
                    return Languages.Mixed;
                }
                //russian
                if((someText[0] >= 'А' && someText[0] <= 'я' )|| someText[0] == 'ё' || someText[0] == 'Ё')
                {
                    if (someText.Any(x => (x < 'А' || (x > 'я' && x != 'ё' && x != 'Ё'))))
                    {
                        return Languages.Mixed;
                    }
                    return Languages.Russian;
                }
                //english
                if (someText[0] >= 'A' && someText[0] <= 'z')
                {
                    if (someText.Any(x => (x < 'A' || x > 'z')))
                    {
                        return Languages.Mixed;
                    }
                    return Languages.English;
                }
            }
            return Languages.Mixed;
        }
    }
    public enum Languages
    {
        None = 0,
        Russian = 1,
        English = 2,
        Number = 3,
        Mixed = 4
    }
}
