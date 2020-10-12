using System;
using System.Collections.Generic;
using System.Text;
using GeometricShapes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;

//Written by Spencer Johnson

namespace GeometricShapes_Tests
{
    [TestClass]
    public class Triangle_Tests
    {
        [TestMethod]
        public void Verify_That_Number_Of_Sides_Is_3()
        {
            Triangle triangle = new Triangle();

            triangle.NumberOfSides.ShouldBe(3);
        }

        [TestMethod]
        public void Verify_The_Side_Length_May_Be_Set_And_Retrieved()
        {
            Triangle triangle = new Triangle();
            double expectedValue = 1.2d;

            triangle.SideLength = expectedValue;

            triangle.SideLength.ShouldBe(expectedValue);
        }

        [TestMethod]
        public void Verify_The_Perimeter_May_Be_Set_And_Retrieved()
        {
            Triangle triangle = new Triangle();
            double sideLength = 3.4d;
            double expectedValue = 10.2d;

            triangle.SideLength = sideLength;

            triangle.Perimeter().ShouldBe(expectedValue);
        }

        [TestMethod]
        public void Verify_That_Area_Is_Calculated_Accurately()
        {
            Triangle triangle = new Triangle();
            double sideLength = 5.6d;
            double expectedAreaMinimumAcceptable = 13.579;
            double expectedAreaMaximumAcceptable = 13.581;

            triangle.SideLength = sideLength;

            triangle.Area().ShouldBeInRange(expectedAreaMinimumAcceptable, expectedAreaMaximumAcceptable);
        }

        [TestMethod]
        public void Verify_Total_Sum_Of_Angles_Can_Be_Retrieved()
        {
            Triangle triangle = new Triangle();

            triangle.TotalMeasureOfAllAngles().ShouldBe(180);


        }
    }
}
