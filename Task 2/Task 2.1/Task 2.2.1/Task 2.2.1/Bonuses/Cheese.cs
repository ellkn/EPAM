using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2._2._1.Common;

namespace Task_2._2._1.Bonuses
{
    public class Cheese: GameObject
    {
        protected char _cheese;
        public Cheese(Point point)
        {
            _cheese = 'e';
            this.Position = point;
        }
    }
}
