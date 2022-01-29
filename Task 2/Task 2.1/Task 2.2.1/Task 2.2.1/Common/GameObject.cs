using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2._2._1.Abstract;

namespace Task_2._2._1.Common
{
    public abstract class GameObject : IPlaceable
    {
        public Point Position { get; set; }

        public GameObject(Point point)
        {
            Position = point;
        }

        public GameObject() : this(Point.Zero)
        {
        }
    }
}
