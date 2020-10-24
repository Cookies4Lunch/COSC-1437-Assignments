using System;
using System.Runtime.InteropServices;
using AbstractClassLibrary;


namespace Demonstrator_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Spencer Johnson Demonstrator 4");
            Console.WriteLine();

            AbstractGeometricShape myGeometricShape;

            myGeometricShape = new Triangle { SideLength = 123.456 };
            TellAboutTheShape(myGeometricShape);

            Console.WriteLine();

            myGeometricShape = new Square() { SideLength = 321.654 };
            TellAboutTheShape(myGeometricShape);

            Console.WriteLine();

            myGeometricShape = new Pentagon() { SideLength = 1.123 };
            TellAboutTheShape(myGeometricShape);

            Console.WriteLine();
            Console.Write("Press any key to continue");
            Console.ReadKey();
l
        }

        static void TellAboutTheShape(AbstractGeometricShape thisShape)
        {
            Console.WriteLine($"This object is a {thisShape.GetType()}");
            Console.WriteLine(thisShape.Description());
            Console.WriteLine($"Number of Sides = {thisShape.NumberOfSides}");
            Console.WriteLine($"Length of the Sides = {thisShape.SideLength}");
            Console.WriteLine($"Perimeter of the shape = {thisShape.Perimeter()}");
            Console.WriteLine($"Area of the shape = {thisShape.Area()}");
            Console.WriteLine();
        }
    }
}
