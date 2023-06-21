using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    abstract class Shape
    {
        public abstract double CalculateArea();
    }

    class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
    }

    class Rectangle : Shape
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public override double CalculateArea()
        {
            return width * height;
        }
    }

    class Triangle : Shape
    {
        private double base1;
        private double height;

        public Triangle(double base1, double height)
        {
            this.base1 = base1;
            this.height = height;
        }

        public override double CalculateArea()
        {
            return 0.5 * base1 * height;
        }
    }
}
