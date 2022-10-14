using System;

namespace OOP
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the radius of the circle: ");
            int r = int.Parse(Console.ReadLine());
            var circle = new Circle(r);
            Console.WriteLine($"Circle P: {circle.GetPerimeter()} | S: {circle.GetSquare()}");

            Console.Write("Enter the side of the square: ");
            int s = int.Parse(Console.ReadLine());
            var square = new Square(s);
            Console.WriteLine($"Square P: {square.GetPerimeter()} | S: {square.GetSquare()}");

            Console.Write("Enter the sides of the rectangle: ");
            int s1 = int.Parse(Console.ReadLine());
            int s2 = int.Parse(Console.ReadLine());
            var rectangle = new Rectangle(s1, s2);
            Console.WriteLine($"Rectangle P: {rectangle.GetPerimeter()} | S: {rectangle.GetSquare()}");

            Console.Write("Enter the side of the rhomb and angle: ");
            int s3 = int.Parse(Console.ReadLine());
            double a = double.Parse(Console.ReadLine());
            var rhomb = new Rhomb(s3, a);
            Console.WriteLine($"Rhomb P: {rhomb.GetPerimeter()} | S: {rhomb.GetSquare()}");
        }
    }
}
