using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._3._1
{
    public static class SuperArray
    {
        public static void Transformation<T>(this T[] array, Func<T, T> func) where T : notnull
        {
            for (var i = 0; i < array.Length; i++)
            {
                array[i] = func(array[i]);
                Console.WriteLine(array[i]);
            }
        }
        /*public static T Summ<T>(this IEnumerable<T> source) where T : // (число... а как ?) 
        {
            return source.Sum<T>();
        }*/
        //так не работает
        // or 
        public static int Summ(this IEnumerable<int> source)
        {
            int result = 0;
            foreach (var i in source)
            {
                result += i;
            }
            return result;
        }
        public static double Summ(this IEnumerable<double> source)
        {
            double result = 0;
            foreach (var i in source)
            {
                result += i;
            }
            return result;
        }
        public static decimal Summ(this IEnumerable<decimal> source)
        {
            decimal result = 0;
            foreach (var i in source)
            {
                result += i;
            }
            return result;
        }
        public static long Summ(this IEnumerable<long> source)
        {
            long result = 0;
            foreach (var i in source)
            {
                result += i;
            }
            return result;
        }
        public static float Summ(this IEnumerable<float> source)
        {
            float result = 0;
            foreach (var i in source)
            {
                result += i;
            }
            return result;
        }
        public static byte Summ(this IEnumerable<byte> source)
        {
            byte result = 0;
            foreach (var i in source)
            {
                result += i;
            }
            return result;
        }
        public static T Average<T>(this IEnumerable<T> source)
        {
            return source.Average();
        }
        // or
        public static double Average(this IEnumerable<double> source)
        { 
            return (double)source.Summ() / (double)source.Count();
        }
        public static T MostCommonElement<T>(this IEnumerable<T> source) where T : notnull
        {
            Dictionary<T, int> commonElements = new Dictionary<T, int>();
            foreach (var element in source)
            {
                if (commonElements.ContainsKey(element))
                {
                    commonElements[element]++;
                }
                else
                {
                    commonElements.Add(element, 0);
                }
            }
            return commonElements.Where( x => x.Value == commonElements.Max(x => x.Value)).FirstOrDefault().Key;
        }
    }
}
