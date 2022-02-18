using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_3._3._3
{
    public class Pizzaria
    {
        public event Action Ready = delegate { };
        int number = 0;
        public Queue<Order> orderList = new Queue<Order>();
        public int GenerateOrderNumber()
        {
            return ++number;
        }
        public void AddOrder(Order order)
        {
            order.OrderNumber = GenerateOrderNumber();
            orderList.Enqueue(order);
            Console.WriteLine($"Your ourder number is : {order.OrderNumber}");
            Cooking();
        }
        public void Cooking()
        {
            
            while(orderList.Count > 0)
            {
                Thread.Sleep(1000);
                Console.WriteLine($"Order {orderList.Peek().OrderNumber} is completed.");
                orderList.Dequeue();
            }
        }
        public void IsReady()
        {
            string status = "Ready";
            Ready();
        }
    }
}
