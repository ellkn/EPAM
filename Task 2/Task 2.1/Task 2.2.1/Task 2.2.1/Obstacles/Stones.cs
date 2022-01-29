using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2._2._1.Common;

namespace Task_2._2._1.Obstacles
{
    public class Stones : GameObject
    {
        private char _stone;
        public Stones(Point point)
        {
            _stone = 'o';
            this.Position = point;
        }
    }
}
