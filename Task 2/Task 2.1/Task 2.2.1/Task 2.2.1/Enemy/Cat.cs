using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2._2._1.Common;

namespace Task_2._2._1.Enemy
{
    public class Cat : MovableObject
    {
        protected char _cats = 'C';
        public Cat() : base(Point.Zero)
        {
        }

        public Cat(Point point) : base(point)
        {
        }

        public override string ToString()
        {
            return $"Cats, Positon: { Position }";
        }
    }
}
