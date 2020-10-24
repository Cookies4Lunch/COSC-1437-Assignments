using System;
using System.Collections.Generic;
using System.Text;

//Written by Spencer Johnson

namespace AbstractClassLibrary
{
    public class Square : AbstractGeometricShape
    {
        public Square()
        {
            NumberOfSides = 4;
        }

        public override double Area() => SideLength * SideLength;

        public override string Description()
        {
            return $"This square is a {NumberOfSides}-sided shape.";
        }
    }
}
