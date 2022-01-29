using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2._1._2.Abstract;

namespace Task_2._1._2.Figures
{
    internal class Circle : RoundFigures 
    {
        public override string Name => "Круг";
        public override double Perimeter => 2 * Math.PI * Radius;
        public override double Area => Math.PI * Radius * Radius;
        public Circle(Point center, double radius) : base(center, radius) { }
    }
}