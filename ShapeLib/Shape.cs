using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeLib
{
    public abstract class Shape
    {
        public abstract string ShapeName();
        public abstract double Area();
        public void Draw()
        {
            Console.WriteLine(
                $"Shape name: {ShapeName()}\n" +
                $"Area: {Area()}\n"
                );
            Console.WriteLine();
        }
    }
}
