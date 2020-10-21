using GeometricShapes;
using System;

//written by Spencer Johnson

namespace Demonstrator_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Spencer Johnson Demonstrator_2");
            Console.WriteLine();

            TellAboutTheTriangle(123.456);

            Console.WriteLine();

            TellAboutTheSquare(321.654);

            Console.WriteLine();

            TellAboutThePentagon(1.123);

            Console.WriteLine();

            Console.WriteLine();
            Console.Write("Press any key to continue");
            Console.ReadKey();


        }

        private static void TellAboutTheTriangle(double lengthOfSide)
        {
            var triangle = new Triangle();
            triangle.SideLength = lengthOfSide;
            Console.WriteLine(triangle.Description());
            Console.WriteLine($"Number of Sides = {triangle.NumberOfSides}");
            Console.WriteLine($"Length of the Sides = {triangle.SideLength}");
            Console.WriteLine($"Perimeter of the shape = {triangle.Perimeter()}");
            Console.WriteLine($"Area of the shape = {triangle.Area()}");
            Console.WriteLine();

        }

        private static void TellAboutTheSquare(double lengthOfSide)
        {
            var square = new Square();
            square.SideLength = lengthOfSide;
            Console.WriteLine(square.Description());
            Console.WriteLine($"Number of Sides = {square.NumberOfSides}");
            Console.WriteLine($"Length of the Sides = {square.SideLength}");
            Console.WriteLine($"Perimeter of the shape = {square.Perimeter()}");
            Console.WriteLine($"Area of the shape = {square.Area()}");
            Console.WriteLine();
        }

        private static void TellAboutThePentagon(double lengthOfSide)
        {
            var pentagon = new Pentagon();
            pentagon.SideLength = lengthOfSide;
            Console.WriteLine(pentagon.Description());
            Console.WriteLine($"Number of Sides = {pentagon.NumberOfSides}");
            Console.WriteLine($"Length of the Sides = {pentagon.SideLength}");
            Console.WriteLine($"Perimeter of the shape = {pentagon.Perimeter()}");
            Console.WriteLine($"Area of the shape = {pentagon.Area()}");
            Console.WriteLine();
        }
    }
}
