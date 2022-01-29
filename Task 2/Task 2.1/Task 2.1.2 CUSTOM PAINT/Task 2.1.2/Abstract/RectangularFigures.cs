using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2._1._2.Figures;

namespace Task_2._1._2.Abstract
{
    public abstract class RectangularFigures: Model
    {
        private double _firstSide;
        public double FirstSide
        {
            get { return _firstSide; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Сторона должна быть > 0");
                _firstSide = value;
            }
        }
        protected RectangularFigures(Point center, double firstSide): base(center)
        {
            FirstSide = firstSide;
        }

        public abstract double Perimeter { get; }
        public abstract double Area { get; }
        public override string Properties
        {
            get { return $"Периметр = {Perimeter}, Площадь = {Area}"; }
        }
    }
}
