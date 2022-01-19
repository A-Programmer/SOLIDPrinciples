using System;
namespace SOLID.OpenClosedPrinciple
{
    public abstract class Shape
    {
        public abstract double CalculateArea();
    }

    public class Rectangle : Shape
    {
        public double Height { get; set; }
        public double Width { get; set; }

        public override double CalculateArea()
        {
            return Width * Height;
        }
    }


    public class Circle : Shape
    {
        public double Radius { get; set; }

        public override double CalculateArea()
        {
            return Radius * Radius * 3.14;
        }
    }
}
