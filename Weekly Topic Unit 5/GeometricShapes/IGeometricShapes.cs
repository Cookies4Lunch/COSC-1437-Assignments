using System;
using System.Collections.Generic;
using System.Text;

//Written by Spencer Johnson

namespace GeometricShapes
{
    public interface IGeometricShapes
    {
        int NumberOfSides { get; }
        double SideLength { get; set; }
        double Perimeter();
        double Area();
        int TotalMeasureOfAllAngles();
        string Description();
    }
}
