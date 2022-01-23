using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2._1._2.Abstract;

namespace Task_2._1._2.Figures
{
    internal class Ring:RoundFigures
    {
        public Circle InnerCircle { get; }
        public Circle OuterCircle { get; }
        public override string Name => "Кольцо";
        public override double Area { get; }
        public override double Perimeter { get; }

        public Ring(Point center, double innerCircleRadius, double outerCircleRadius):base(center, innerCircleRadius)
        {
            if (innerCircleRadius == outerCircleRadius)
            {
                Console.WriteLine("Радиусы равны, фигур");
                InnerCircle = new Circle(center, innerCircleRadius);
                Perimeter = InnerCircle.Perimeter;
            }
            else
            {
                InnerCircle = new Circle(center, innerCircleRadius);
                OuterCircle = new Circle(center, outerCircleRadius);
                Perimeter = InnerCircle.Perimeter + OuterCircle.Perimeter;
                Area = OuterCircle.Area - InnerCircle.Area;
            }
            
        }
    }
}