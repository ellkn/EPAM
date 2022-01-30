using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._1._1
{
    public class WeakestLink
    {
        private List<People> _people;
        private int _id;
        public WeakestLink(int capacity, int id)
        {
            _people = new List<People>(capacity);
            for (int i = 0; i < capacity; i++)
            {
                _people.Add(new People(i + 1));
            }
            _id = id;
        }
        public void Run()
        {
            int removedId = _id - 1;
            while(_people.Count > removedId)
            {
                for (int i = 1; _id <= _people.Count; i++) // where i - numbeer of round
                {
                    _people.Remove(_people[removedId]);
                    Console.WriteLine($"Раунд {i}. Вычеркнут человек с номером {_id}. Осталось: {_people.Count} игроков");
                }
            }
            CheckingCorrectness();
        }
        public void CheckingCorrectness()
        {
            if(_people.Count < _id)
            {
                Console.WriteLine("Игра окончена. Невозможно удалить пользователя по индексу, если индекс больше количества пользователей!");
            }
        }
    }
}
