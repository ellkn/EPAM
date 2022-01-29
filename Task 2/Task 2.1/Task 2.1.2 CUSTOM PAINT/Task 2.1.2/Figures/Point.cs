using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2._1._2.Abstract;

namespace Task_2._1._2.Figures
{
    public class Point:Model
    {
        public double X { get; }
        public double Y { get; }
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
        public override string Name { get { return "Точка"; } }
        public override string Properties { get { return $"X = {X}, Y = {Y}"; } }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            return obj is Point point && 
                   X == point.X &&
                   Y == point.Y;
        }
        public static bool operator ==(Point firstPoint, Point secondPoint)
        {
            if(firstPoint is null || secondPoint is null)// вызов прямого сравнения ссылок
            {
                return false;
            }
            return firstPoint.Equals(secondPoint);
        }
        public static bool operator !=(Point firstPoint, Point secondPoint)
        {
            if (firstPoint == null || secondPoint == null) // вызов перегруженного оператора
            {
                return false;
            }
            return !firstPoint.Equals(secondPoint);
        }

        public override string ToString()
        {
            return $"X = {X}, Y = {Y}";
        }
    }
}
