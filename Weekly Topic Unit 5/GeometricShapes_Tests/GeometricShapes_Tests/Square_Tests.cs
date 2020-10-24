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
    public class Square_Tests
    {
        [TestMethod]
        public void Verify_That_Number_Of_Sides_Is_3()
        {
            Square square = new Square();

            square.NumberOfSides.ShouldBe(4);
        }

        [TestMethod]
        public void Verify_The_Side_Length_May_Be_Set_And_Retrieved()
        {
            Square square = new Square();
            double expectedValue = 3.14d;

            square.SideLength = expectedValue;

            square.SideLength.ShouldBe(expectedValue);
        }

        [TestMethod]
        public void Verify_The_Perimeter_May_Be_Set_And_Retrieved()
        {
            Square square = new Square();
            double sideLength = 1.5d;
            double expectedPerimeter = 6d;

            square.SideLength = sideLength;

            square.Perimeter().ShouldBe(expectedPerimeter);
        }

        [TestMethod]
        public void Verify_That_Area_Is_Calculated_Accurately()
        {
            Square square = new Square();
            double sideLength = 2d;
            double minimumValuePossible = 3.9d;
            double maximumValuePossible = 4.1d;

            square.SideLength = sideLength;

            square.Area().ShouldBeInRange(minimumValuePossible, maximumValuePossible);
        }

        [TestMethod]
        public void Verify_Total_Sum_Of_Angles_Can_Be_Retrieved()
        {
            Square square = new Square();

            square.TotalMeasureOfAllAngles().ShouldBe(180);

            
        }

        [TestMethod]
        public void Verify_The_Description_Returns_Value()
        {
            var square = new Square();

            square.Description().ShouldNotBeNullOrWhiteSpace();
        }
    }
}
