using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeLib
{
    public class Triangle : Shape
    {
        protected int _sideOne;
        protected int _sideTwo;
        protected int _sideThree;
        public int SideOne
        {
            get => _sideOne;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                _sideOne = value;
            }
        }
        public int SideTwo
        {
            get => _sideTwo;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                _sideTwo = value;
            }
        }
        public int SideThree
        {
            get => _sideThree;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                _sideThree = value;
            }
        }
        public double Perimeter { get => SideOne + SideTwo + SideThree; }
        public double AreaTriangle 
            { get => Math.Sqrt(Perimeter / 2 * (Perimeter / 2 - _sideOne)
                * (Perimeter / 2 - _sideTwo)
                * (Perimeter / 2 - _sideThree)); }

        public Triangle(int sideOne, int sideTwo, int sideThree)
        {
            if ((sideOne + sideTwo <= sideThree)
                || (sideOne + sideThree <= sideTwo)
                || (sideTwo + sideThree <= sideOne))
            {
                throw new ArgumentException("The triangle with the given parameters does not exist.");
            }
            SideOne = sideOne;
            SideTwo = sideTwo;
            SideThree = sideThree;
        }
        public override double Area()
        {
            return AreaTriangle;
        }

        public override string ShapeName()
        {
            if ((Math.Pow(_sideOne,2) + Math.Pow(_sideTwo, 2) == Math.Pow(_sideThree, 2))
                || (Math.Pow(_sideOne, 2) + Math.Pow(_sideThree, 2) == Math.Pow(_sideTwo, 2))
                || (Math.Pow(_sideThree, 2) + Math.Pow(_sideTwo, 2) == Math.Pow(_sideOne, 2)))
            {
                return "Right triangle";
            }
            return "Triangle";
        }
    }
}
