using System;
using MyDynamicArray;
using MyCycledDynamicArray;

namespace Task_3._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DynamicArray<int> array = new DynamicArray<int>();
            array.AddRange(new int[] {1, 2, 3, 4, 5, 6});
            array.Print();
            array.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 });
            array.Print(); // проверили корректное добавление в конец массива
            array.Add(5); // при недостатке - место удвоилось
            array.Print();
            array.Add(6); // теперь -  ёмкость не изменилась
            array.Print();
            array.Remove(7); // удалили элемент с индексом 7
            array.Print();
            array.Remove(15); // удалили элемент с индексом 15
            array.Print();
            array.Insert(111, 2);
            array.Print();


            /*DynamicArray<int> newArray = (DynamicArray<int>)array.Clone(); // чтчт не так
            newArray.Print();*/
            

                /*  CycledDynamicArray<int> test = new CycledDynamicArray<int>();
                  test.AddRange(new int[] { 1, 2, 3, 4, 5, 6 });
                  test.Print();
                  int position = 0;
                  foreach (var item in test)
                  {
                      if (position % test.Length == 0)
                      {
                          Console.WriteLine("new round");
                      }
                      Console.WriteLine($"[{position++}] = {item}");
                      Console.ReadKey();// бесконечный цикл...
                  }*/
        }
    }
}
