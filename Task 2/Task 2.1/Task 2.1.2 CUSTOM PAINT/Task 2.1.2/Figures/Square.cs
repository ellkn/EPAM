using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2._1._2.Abstract;

namespace Task_2._1._2.Figures
{
    internal class Square: RectangularFigures
    {
        public Square(Point center, double firstSide) : base(center, firstSide) { }
        public override string Name => "Квадрат";
        public override double Perimeter => 4 * FirstSide;
        public override double Area => FirstSide * FirstSide;
    }
}
