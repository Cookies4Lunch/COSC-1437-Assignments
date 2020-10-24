using System;
using System.Collections.Generic;
using System.Text;

//Written by Spencer Johnson

namespace AbstractClassLibrary
{
    public class Triangle : AbstractGeometricShape
    {
        public Triangle()
        {
            NumberOfSides = 3;
        }

        public override double Area() => (Math.Sqrt(3) / 4) * Math.Pow(SideLength, 2);

        public override string Description()
        {
            return $"This Triangle is a {NumberOfSides}-sided shape";
        }
    }
}
