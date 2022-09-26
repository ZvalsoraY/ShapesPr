using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeLib
{
    public class Circle : Shape
    {
        protected int _radius;
        public int Radius
        {
            get => _radius;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                _radius = value;
            }
        }
        public double Circumference { get => 2 * Math.PI * Radius; }
        public double AreaCircle { get => Math.PI * Math.Pow(Radius,2); }

        public Circle(int radius)
        {
            Radius = radius;
        }
        public override double Area()
        {
            return AreaCircle;
        }

        public override string ShapeName()
        {
            return "Circle";
        }

    }
}
