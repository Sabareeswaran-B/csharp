using System;

namespace AbstractClasses
{
    abstract class Shape
    {
        public abstract int calculateShape();

        public int width { get; set; }

        public int height { get; set; }
    }

    class Rectangle : Shape
    {
        new public int width { get; set; }

        new public int height { get; set; }

        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public override int calculateShape()
        {
            int area = width * height;
            return area;
        }
    }

    class Triangle : Shape
    {
        new public int width { get; set; }

        new public int height { get; set; }

        public Triangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public override int calculateShape()
        {
            int area = (width * height) / 2;
            return area;
        }
    }

    class Circle : Shape
    {
        public int radius { get; set; }
        new public int width { get; set; }

        new public int height { get; set; }

        public Circle(int radius)
        {
            this.radius = radius;
        }

        public override int calculateShape()
        {
            double area = 3.14 * (double)radius * (double)radius;
            return (int)area;
        }
    }

    class Program
    {
        // public static void Main(string[] args)
        // {
        //     Shape rectangle = new Rectangle(5, 6);
        //     Shape triangle = new Triangle(7, 8);
        //     Shape circle = new Circle(3);

        //     Shape[] shapes = { rectangle, triangle, circle };

        //     int[] areas = new int[3];

        //     for (var i = 0; i < shapes.Length; i++)
        //     {
        //         int area = shapes[i].calculateShape();
        //         areas[i] = area;
        //     }

        //     foreach (var area in areas)
        //     {
        //         Console.WriteLine(area);
        //     }
        // }
    }
}