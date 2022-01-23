using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2._1._2.Abstract;

namespace Task_2._1._2.Figures
{
    internal class Line : Model
    {
        private Point _lastPoint;

        public Point FirstPoint { get; }
        public Point LastPoint 
        {
            get { return _lastPoint; }
            set { 
                if (value.Equals(_lastPoint)) 
                    throw new ArgumentException("Start and End points of the line should be different");
                _lastPoint = value; 
            }
        }
        public double Length { get; }
        public override string Name { get { return "Линия"; } }
        public override string Properties { get { return $"Первая точка -> {FirstPoint}, Вторая точка -> {LastPoint}"; } }
        public Line(double x1, double y1, double x2, double y2)
        {
            FirstPoint = new Point(x1, y1);
            LastPoint = new Point(x2, y2);
            Length = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
        }

        public Line(Point firstPoint, Point lastPoint)
        {
            FirstPoint = firstPoint;
            LastPoint = lastPoint;
            Length = Math.Sqrt(Math.Pow((LastPoint.X - FirstPoint.X), 2) +
                (Math.Pow((LastPoint.Y - FirstPoint.Y), 2)));
        }
    }
}
