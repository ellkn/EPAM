using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_3._3._1
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            double[] array = { 1, 2, 3 };
            array.Transformation(x => x*2);
            double Sum = array.Summ();
            Console.WriteLine(Sum);
            double Average = array.Average();
            Console.WriteLine(Average);
            double Elementscommon = array.MostCommonElement();
            Console.WriteLine(Elementscommon);

            int[] arrays = { 1, 2, 3 };
            arrays.Transformation(x => x*2);
            int Summa = arrays.Summ(); 
            Console.WriteLine(Summa);
            //e.t.c.
        }
    }
}
