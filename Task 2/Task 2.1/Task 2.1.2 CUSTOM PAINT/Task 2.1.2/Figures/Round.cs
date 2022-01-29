using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2._1._2.Abstract;

namespace Task_2._1._2.Figures
{
    internal class Round:RoundFigures
    {
        public override string Name => "Окружность";
        public override double Perimeter => 2 * Math.PI * Radius;
        public override double Area => 0;
        public Round(Point center, double radius) : base(center, radius) { }
    }
}
