// using System;

// namespace AbstractClasses
// {
//     abstract class Shape
//     {
//         public abstract Double calculatePerimeter();
//     }

//     abstract class Shape2
//     {
//         public abstract double SquareArea(double side);
//         public abstract double RectangleArea(double length, double breadth);
//         public abstract double CircleArea(double radius);
//     }

//     class Area : Shape2
//     {
//         public override double SquareArea(double side)
//         {
//             return side * side;
//         }

//         public override double CircleArea(double radius)
//         {
//             return 3.14 * radius * radius;
//         }

//         public override double RectangleArea(double length, double breadth)
//         {
//             return length * breadth;
//         }
//     }

//     class Circle : Shape
//     {
//         public override double calculatePerimeter()
//         {
//             Console.Write("Enter the radius:");
//             double radius = Convert.ToDouble(Console.ReadLine());
//             double result = 3.14 * 2 * radius;
//             return result;
//         }
//     }

//     class Square : Shape
//     {
//         public override double calculatePerimeter()
//         {
//             Console.Write("Enter the side:");
//             double side = Convert.ToDouble(Console.ReadLine());
//             double result = 4 * side;
//             return result;
//         }
//     }

//     class Rectangle : Shape
//     {
//         public override double calculatePerimeter()
//         {
//             Console.Write("Enter the length:");
//             double length = Convert.ToDouble(Console.ReadLine());
//             Console.Write("Enter the breadth:");
//             double breadth = Convert.ToDouble(Console.ReadLine());
//             double result = 2 * (length + breadth);
//             return result;
//         }
//     }

//     class ExcerciseOne
//     {
//         public void run()
//         {
//             Circle circle = new Circle();
//             Square square = new Square();
//             Rectangle rectangle = new Rectangle();
//             Console.Write("List of shapes\n1.Circle\n2.Rectangle\n3.Square\nEnter your choice:");
//             int choice = Convert.ToInt32(Console.ReadLine());
//             double perimeter = 0.0;
//             switch (choice)
//             {
//                 case 1:
//                     perimeter = circle.calculatePerimeter();
//                     Console.WriteLine($"The Perimeter is {perimeter}");
//                     break;
//                 case 2:
//                     perimeter = rectangle.calculatePerimeter();
//                     Console.WriteLine($"The Perimeter is {perimeter}");
//                     break;
//                 case 3:
//                     perimeter = square.calculatePerimeter();
//                     Console.WriteLine($"The Perimeter is {perimeter}");
//                     break;
//                 default:
//                     Console.WriteLine("Invalid Input, Enter a correct choice");
//                     break;
//             }
//         }
//     }

//     class ExcerciseSix
//     {
//         public void run()
//         {
//             Area area = new Area();
            
//             Console.Write("Enter the radius:");
//             double radius = Convert.ToDouble(Console.ReadLine());

//             Console.WriteLine($"The area of a circle with radius {radius} is {area.CircleArea(radius)}");

//             Console.Write("Enter the side:");
//             double side = Convert.ToDouble(Console.ReadLine());

//             Console.WriteLine($"The area of a square with side {side} is {area.SquareArea(side)}");

//              Console.Write("Enter the length:");
//             double length = Convert.ToDouble(Console.ReadLine());
//             Console.Write("Enter the breadth:");
//             double breadth = Convert.ToDouble(Console.ReadLine());

//             Console.WriteLine($"The area of a rectangle with length {length} and breadth {breadth} is {area.RectangleArea(length, breadth)}");
//         }
//     }
// }
