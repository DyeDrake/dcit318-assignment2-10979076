using System;

namespace ShapeExample
{
    abstract class Shape
    {
        public abstract double GetArea();

    }

    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        // Implement GetArea
        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    class Rectagle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectagle(double width, double height)
        {
            Height = height;
            Width = width;
        }
        
        public override double GetArea()
        {
            return Width * Height;
        }
    }

    class Program
    {
        static void Main(String[] args)
        {
            Circle circle = new Circle(12.034);
            Rectagle rectagle = new Rectagle(7.48, 20.76);
            
            Console.WriteLine($"Area of the circle is {circle.GetArea()}m(Square) with radius {circle.Radius}m");
            Console.WriteLine($"Area of the Rectangle is {rectagle.GetArea()}m(Square) with respective height and width" +
                              $" {rectagle.Height}m, {rectagle.Width}m");
        }
    }
}