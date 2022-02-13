using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._3._3
{
    public class Order
    {
        public int OrderNumber { get; set; } 
        List<Pizza> Pizzas = new List<Pizza>();
        public int OrderPrice { get; set; }
        private User user;
        
        public Order(User user, List<Pizza> _pizzas)
        {
            this.user = user;
            this.Pizzas = _pizzas;
        }
    }
}
