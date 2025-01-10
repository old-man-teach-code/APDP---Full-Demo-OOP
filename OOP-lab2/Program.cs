using System;

namespace OOP_lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle t = new Triangle();
            t.BaseTriangle = 1;
            Console.WriteLine("New Base Triangle = " + t.BaseTriangle);
        }
    }

    abstract class Figure
    {
        public abstract double Area();
    }

    class Triangle : Figure
    {
        public double baseTriangle;
        public double BaseTriangle
        {
            get { return baseTriangle; }
            set
            {
                if (value > 0)
                {
                    baseTriangle = value;
                    Console.WriteLine("Base Triangle has been set to " + value);
                } else {
                    Console.WriteLine("Base Triangle cant be less or equal 0");
                }
            }
        }
        public double heightTriangle;
        public double HeightTriangle
        {
            get { return heightTriangle; }
            set
            {
                if (value > 0)
                {
                    heightTriangle = value;
                    Console.WriteLine("heightTriangle has been set to " + value);
                }
                else
                {
                    Console.WriteLine("heightTriangle cant be less or equal 0");
                }
            }
        }

        public override double Area()
        {
            return (this.baseTriangle * this.heightTriangle) / 2;
        }
    }

    class Circle : Figure
    {
        public double radius { get; set;}

        public override double Area()
        {
            return (this.radius * this.radius) * 3.14;
        }
    }

    class Retangle : Figure
    {
        public double width { get; set;}
        public double height { get; set;}

        public override double Area()
        {
            return (this.width * this.height);
        }
    }

    class Trapezium : Figure
    {
        public double longBaseTrapezium { get; set; }
        public double shortBaseTrapezium { get; set; }
        public double height { get; set;}
        

        public override double Area()
        {
            return (this.longBaseTrapezium + this.shortBaseTrapezium) * height / 2;
        }
    }
}
