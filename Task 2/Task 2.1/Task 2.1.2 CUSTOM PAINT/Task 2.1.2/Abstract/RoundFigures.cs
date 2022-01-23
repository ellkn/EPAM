using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2._1._2.Figures;
namespace Task_2._1._2.Abstract
{
    public abstract class RoundFigures: Model
    {
        private double _radius;
        public double Radius
        {
            get { return _radius; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Радиус должен быть положительным > 0");
                _radius = value;
            }
        }
        protected RoundFigures(Point center, double radius) : base(center) 
        {
            Radius = radius;
        }
        public abstract double Perimeter { get; }
        public abstract double Area { get; }
        public override string Properties 
        {
            get { return $"Периметр = {Perimeter}, Площадь = {Area}"; }
        }
    }
}
