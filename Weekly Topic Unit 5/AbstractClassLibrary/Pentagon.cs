using System;
using System.Collections.Generic;
using System.Text;

//Written by Spencer Johnson

namespace AbstractClassLibrary
{
    public class Pentagon : AbstractGeometricShape
    {
        public Pentagon()
        {
            NumberOfSides = 5;
        }

        public override double Area() => (Math.Sqrt(25 + 10 * Math.Sqrt(5)) / 4) * Math.Pow(SideLength, 2);

        public override string Description()
        {
            return $"This pentagon is a {NumberOfSides}-sided shape.";
        }
    }
}
