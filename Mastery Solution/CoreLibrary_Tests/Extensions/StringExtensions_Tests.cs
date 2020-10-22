using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using CoreLibrary.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;



//Written by Spencer Johnson



namespace CoreLibrary_Tests
{
    [TestClass]
    public class StringExtensions_Tests
    {
        #region IsNullOrEmpty
        
        

        [DataTestMethod]
        [DataRow("", true)]
        [DataRow(" ", false)]
        [DataRow(null, true)]
        [DataRow("Spencer Johnson", false)]
        public void IsNullOrEmpty_Test(string content, bool expectedResult)
        {
            var actualResult = content.IsNullOrEmpty();
            
            actualResult.ShouldBe(expectedResult);  
        }


        /*
        [TestMethod]
        public void IsNullOrEmpty_IsNull()
        {
            string testCondition = null;

            var actualResult = testCondition.IsNullOrEmpty();

            actualResult.ShouldBeTrue();
        }

        [TestMethod]
        public void IsNullOrEmpty_IsEmpty()
        {
            string testCondition = "";

            testCondition.ShouldBeEmpty();
        }
        */
        #endregion



        #region IsNullorWhiteSpace

        [DataTestMethod]
        [DataRow("", true)]
        [DataRow(" ", true)]
        [DataRow(null, true)]
        [DataRow("Spencer Johnson", false)]
        public void IsNullOrWhiteSpace_Test(string content, bool expectedResult)
        {
            var actualResult = content.IsNullOrWhiteSpace();

            actualResult.ShouldBe(expectedResult);
        }

        /*
        [TestMethod]
        public void IsNullOrWhiteSpace_IsNull()
        {
            string testCondition = null;

            var actualResult = testCondition.IsNullOrWhiteSpace();

            actualResult.ShouldBeTrue();
        }

        [TestMethod]
        public void IsNullOrWhiteSpace_IsEmpty()
        {
            string testCondition = "";

            var actualResult = testCondition.IsNullOrWhiteSpace();

            actualResult.ShouldBeTrue();
        }

        [TestMethod]
        public void IsNullOrWhiteSpaces_IsSpaces()
        {
            string testCondition = "    ";

            var actualResult = testCondition.IsNullOrWhiteSpace();

            actualResult.ShouldBeTrue();
        }
        */

        #endregion

        #region Left

        [DataTestMethod]
        [DataRow("Spencer Johnson", 8, "Spencer ")]
        [DataRow("Spencer Johnson", 99, "Spencer Johnson")]
        [DataRow("Spencer Johnson", 0, "")]
        [DataRow(null, 0, null)]
        public void Left_Test (string testCondition, int numCharacters, string expectedResult)
        {
            var actualResult = testCondition.Left(numCharacters);

            actualResult.ShouldBe(expectedResult);
        }

        /*
        [TestMethod]
        public void Left_Normal()
        {
            string testCondition = "Spencer";
            int numCharacters = 4;

            var actualResult = testCondition.Left(numCharacters);

            actualResult.ShouldBe("Spen");
        }

        [TestMethod]
        public void Left_IsNull()
        {
            string testCondition = null;

            var actualResult = testCondition.Left(1);

            actualResult.ShouldBeNull();
        }

        [TestMethod]
        public void Left_NoCharacters()
        {
            string testCondition = "";

            var actualResult = testCondition.Left(1);

            actualResult.ShouldBeEmpty();
        }

        [TestMethod]
        public void Left_TooManyCharacters()
        {
            string testCondition = "Hello";

            var actualResult = testCondition.Left(3);

            actualResult.Length.ShouldBe(3);
        }
        */

        #endregion

        #region Right

        [DataTestMethod]
        [DataRow("Spencer Johnson", 8, " Johnson")]
        [DataRow("Spencer Johnson", 99, "Spencer Johnson")]
        [DataRow("Spencer Johnson", 0, "")]
        [DataRow(null, 0, null)]
        public void Right_Test(string testCondition, int numCharacters, string expectedResult)
        {
            var actualResult = testCondition.Right(numCharacters);

            actualResult.ShouldBe(expectedResult);
        }

        /*
        [TestMethod]
        public void Right_Normal()
        {
            string testCondition = "Spencer";
            int numCharacters = 4;

            var actualResult = testCondition.Right(numCharacters);

            actualResult.ShouldBe("ncer");
        }

        [TestMethod]
        public void Right_IsNull()
        {
            string testCondition = null;

            var actualResult = testCondition.Right(1);

            actualResult.ShouldBeNull();
        }

        [TestMethod]
        public void Right_NoCharacters()
        {
            string testCondition = "";

            var actualResult = testCondition.Right(1);

            actualResult.ShouldBeEmpty();
        }

        [TestMethod]
        public void Right_TooManyCharacters()
        {
            string testCondition = "Hello";

            var actualResult = testCondition.Right(3);

            actualResult.Length.ShouldBe(3);
        }
        */

        #endregion


    }
}


