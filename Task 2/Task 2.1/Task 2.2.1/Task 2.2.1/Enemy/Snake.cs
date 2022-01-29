using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2._2._1.Common;

namespace Task_2._2._1.Enemy
{
    public class Snake : MovableObject
    {
        protected char _snake = 'S';
        public Snake() : base(Point.Zero)
        {
        }

        public Snake(Point point) : base(point)
        {
        }

        public override string ToString()
        {
            return $"Snakes, Positon: { Position }";
        }
    }
}
