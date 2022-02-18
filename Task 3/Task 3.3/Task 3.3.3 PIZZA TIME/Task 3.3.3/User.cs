using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._3._3
{
    public class User
    {
        public string Name { get; set; }
        public User(string name)
        {
            this.Name = name;
        }
        public void OrderPizza(Pizzaria pizzaria, Dictionary<PizzaType, int> _orders)
        {
            List<Pizza> _pizzas = new List<Pizza>();
            int sum = 0;
            foreach(var _order in _orders)
            {
                for (int i = 0; i < _order.Value; i++)
                {
                    Pizza pizza = new (_order.Key);
                    _pizzas.Add(pizza);
                    sum += pizza.Price;
                }
            }
            Order order = new Order(this, _pizzas);
            order.OrderPrice = sum;
            Console.WriteLine($"Your order sum is : {sum}");
            pizzaria.AddOrder(order);
           
        }
        public void TakePizza(Pizzaria pizzeria)
        {
        }
    }
}
