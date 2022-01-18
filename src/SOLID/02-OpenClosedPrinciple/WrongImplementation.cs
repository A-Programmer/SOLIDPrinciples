using System;
namespace SOLID.OpenClosedPrinciple
{
    public class RectangleShape
    {
        public double Width { get; set; }
        public double Height { get; set; }
    }

    public class CircleShape
    {
        public double Radius { get; set; }
    }

    public class AreaCalculator
    {
        public double Calculate(object shape)
        {
            if (shape is RectangleShape)
            {
                RectangleShape rectangle = (RectangleShape)shape;
                return rectangle.Width * rectangle.Height;
            }
            else
            {
                CircleShape circle = (CircleShape)shape;
                return circle.Radius * circle.Radius * 3.14;
            }
        }
    }

}
