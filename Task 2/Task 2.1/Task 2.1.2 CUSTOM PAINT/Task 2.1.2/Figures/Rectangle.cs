using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2._1._2.Abstract;

namespace Task_2._1._2.Figures
{
    internal class Rectangle:RectangularFigures
    {
        private double _secondSide;
        public double SecondSide // second side
        {
            get { return _secondSide; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Сторона должна быть > 0");
                _secondSide = value;
            }
        }
        public override string Name => "Прямоугольник";
        public override double Perimeter => 2 * (FirstSide + SecondSide);
        public override double Area => FirstSide * SecondSide;
        public Rectangle(Point center, double firstSide, double _secondSide) : base(center, firstSide)
        {
            SecondSide = _secondSide;
        }

    }
}
