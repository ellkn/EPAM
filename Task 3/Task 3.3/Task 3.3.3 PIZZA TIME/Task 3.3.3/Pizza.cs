using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._3._3
{
    public class Pizza
    {
        public static readonly int MARGARITA_PRICE    = 300;
        public static readonly int FOUR_SEASONS_PRICE = 300;
        public static readonly int PEPPERONI_PRICE    = 400;
        public static readonly int CLASSIC_PRICE      = 550;
        public static readonly int ASSORTED_PRICE     = 670;
        public PizzaType PizzaType { get; }
        public int Price { get; set; }
        public Pizza(PizzaType pizza)
        {
            this.PizzaType = pizza;
            SetPizzaPrice(pizza);

        }

        private void SetPizzaPrice(PizzaType pizzaType)
        {
            switch (pizzaType)
            {
                case PizzaType.Margarita: Price = MARGARITA_PRICE; break;
                case PizzaType.FourSeasons: Price = FOUR_SEASONS_PRICE; break;
                case PizzaType.Pepperoni: Price = PEPPERONI_PRICE; break;
                case PizzaType.Classic: Price = CLASSIC_PRICE; break;
                case PizzaType.Assorted: Price = ASSORTED_PRICE; break;
            }
        }
    }
    public enum PizzaType
    {
        None,
        Margarita,
        FourSeasons,
        Pepperoni, 
        Classic,
        Assorted
    }
}
