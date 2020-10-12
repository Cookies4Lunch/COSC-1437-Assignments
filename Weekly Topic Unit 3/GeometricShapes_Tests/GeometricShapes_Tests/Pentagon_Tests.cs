using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeometricShapes;
using Shouldly;

//Written by Spencer Johnson

namespace GeometricShapes_Tests
{
    [TestClass]
    public class Pentagon_Tests
    {
        [TestMethod]
        public void Verify_That_Number_Of_Sides_Is_5()
        {
            Pentagon pentagon = new Pentagon();

            pentagon.NumberOfSides.ShouldBe(5);
        }

        [TestMethod]
        public void Verify_The_Side_Length_May_Be_Set_And_Retrieved()
        {

            Pentagon pentagon = new Pentagon();
            double expectedValue = 3.14d;

            pentagon.SideLength = expectedValue;

            pentagon.SideLength.ShouldBe(expectedValue);
            
        }

        [TestMethod]
        public void Verify_The_Perimeter_May_Be_Set_And_Retrieved()
        {
            Pentagon pentagon = new Pentagon();
            double sideLength = 2d;
            double expectedPerimeter = 10d;

            pentagon.SideLength = sideLength;

            pentagon.Perimeter().ShouldBe(expectedPerimeter);
        }

        [TestMethod]
        public void Verify_That_Area_Is_Calculated_Accurately()
        {
            Pentagon pentagon = new Pentagon();
            double sideLength = 7d;
            double minimumValuePossible = 84.29d;
            double maximumValuePossible = 84.31d;

            pentagon.SideLength = sideLength;

            pentagon.Area().ShouldBeInRange(minimumValuePossible, maximumValuePossible);
        }

        [TestMethod]
        public void Verify_Total_Sum_Of_Angles_Can_Be_Retrieved()
        {
            Pentagon pentagon = new Pentagon();

            pentagon.TotalMeasureOfAllAngles().ShouldBe(180);


        }
    }
}
