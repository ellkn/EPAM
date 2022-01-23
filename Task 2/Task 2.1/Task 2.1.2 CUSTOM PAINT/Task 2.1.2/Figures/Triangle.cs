using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2._1._2.Abstract;

namespace Task_2._1._2.Figures
{
    internal class Triangle : Model
    {
        private Line firstLine;
        private Line secondLine;
        private Line thirdLine;
        public override string Name => "Треугольник";
        public override string Properties 
        {
            get 
            {
                return $"Первая сторона -> {firstLine}, Вторая сторона -> {secondLine}, Третья сторона -> {thirdLine}"; 
            } 
        }
        public double Perimeter => firstLine.Length + secondLine.Length + thirdLine.Length;
        //периметр можно вычислить с помощью формулы Герона S = sqrt(p*(p-a)*(p-b)*(p-c))
        //где р = полупериметр = (a+b+c)/2, а (a, b, c) - стороны треугольника
        public double Area => Math.Sqrt((Perimeter / 2) * ((Perimeter / 2) - firstLine.Length) * ((Perimeter / 2) - secondLine.Length) * ((Perimeter / 2) - thirdLine.Length));
        public Triangle(Point firstPoint, Point secondPoint, Point thirdPoint) : base(firstPoint)
        {
            firstLine = new Line(firstPoint, secondPoint);
            secondLine = new Line(secondPoint, thirdPoint);
            thirdLine = new Line(thirdPoint, firstPoint);
        }
    }
}
