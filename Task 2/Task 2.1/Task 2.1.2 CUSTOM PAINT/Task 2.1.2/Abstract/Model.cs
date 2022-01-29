using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2._1._2.Figures;

namespace Task_2._1._2.Abstract
{
    public abstract class Model
    {
        public abstract string Name { get; }
        public abstract string Properties { get; }
        public Point Center { get; }
        public Model() { }
        public Model(Point center)
        {
            Center = center;
        }
    }
}
