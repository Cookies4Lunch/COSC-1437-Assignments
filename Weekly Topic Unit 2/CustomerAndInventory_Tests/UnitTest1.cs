using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ComponentModel.DataAnnotations;

namespace CustomerAndInventory_Tests
{
    [TestClass]
    public class Customer_Tests
    {
        [TestMethod]
        public void Verify_The_ID_Is_Zero_When_Instantiated()
        {
            var customer = new CustomerAndInventory.Customer();

            Assert.AreEqual(0, customer.ID);
        }

        [TestMethod]
        public void Verify_The_ID_Can_Be_Assigned()
        {
            var assignedIDtest = 1234;
            var customer = new CustomerAndInventory.Customer();

            customer.ID = assignedIDtest;

            Assert.AreEqual(assignedIDtest, customer.ID);
        }

        [TestMethod]
        public void Verify_The_First_Name_Can_Be_Assigned()
        {
            var tempFirst = "Bobberino";
            var customer = new CustomerAndInventory.Customer();

            customer.FirstName = tempFirst;

            Assert.AreEqual(tempFirst, customer.FirstName);
        }

        [TestMethod]
        public void Verify_The_Last_Name_Can_Be_Assigned()
        {
            var tempLast = "Jonesy";
            var customer = new CustomerAndInventory.Customer();

            customer.LastName = tempLast;

            Assert.AreEqual(tempLast, customer.LastName);
        }

        [TestMethod]
        public void Verify_The_Full_Name_Represents_The_First_And_Last_Names()
        {
            var tempFirst = "John";
            var tempLast = "Doe";
            var tempFull = tempFirst + " " + tempLast;
            var customer = new CustomerAndInventory.Customer();


            customer.FirstName = tempFirst;
            customer.LastName = tempLast;
            customer.FullName();

            Assert.AreEqual(customer.FullName(), tempFull);
        }

        [TestMethod]
        public void Verify_The_ValidateName_Returns_True_If_Both_Names_Have_2_Or_More_Characters()
        {
            var tempFirst = "John";
            var tempLast = "Doe";
            var customer = new CustomerAndInventory.Customer();

            customer.FirstName = tempFirst;
            customer.LastName = tempLast;

            customer.ValidateName();

            Assert.AreEqual(customer.ValidateName(), true);
        }
    }

    [TestClass]
    public class Order_Tests
    {
        [TestMethod]
        public void Verify_The_ID_Can_Be_Assigned()
        {
            var assignedID = 1234;
            var order = new CustomerAndInventory.Order();

            order.ID = assignedID;

            Assert.AreEqual(order.ID, assignedID);
        }

        [TestMethod]
        public void Verify_Assignment_Of_Customer_ID()
        {
            var tempID = 1234;
            var order = new CustomerAndInventory.Order();
            var customer = new CustomerAndInventory.Customer();

            customer.ID = tempID;
            order.CustomerID = customer.ID;

            Assert.AreEqual(tempID, customer.ID);
            Assert.AreEqual(customer.ID, order.CustomerID);
        }
    }

    [TestClass]
    public class OrderItem_Tests
    {
        [TestMethod]
        public void Verify_ID_Can_Be_Assigned()
        {
            var assignedID = 1234;
            var orderItem = new CustomerAndInventory.OrderItem();

            orderItem.ID = assignedID;

            Assert.AreEqual(orderItem.ID, assignedID);
        }

        [TestMethod]
        public void Verify_Assignment_Of_Order_ID()
        {
            var tempID = 1234;
            var order = new CustomerAndInventory.Order();
            var orderItem = new CustomerAndInventory.OrderItem();

            order.ID = tempID;
            orderItem.OrderID = order.ID;

            Assert.AreEqual(order.ID, orderItem.OrderID);
        }

        [TestMethod]
        public void Verify_Assignment_Of_Product_ID()
        {
            var tempID = 1234;
            var orderItem = new CustomerAndInventory.OrderItem();
            var product = new CustomerAndInventory.Product();

            product.ID = tempID;
            orderItem.ProductID = product.ID;

            Assert.AreEqual(product.ID, orderItem.ProductID);
        }
    }

    [TestClass]
    public class Product_Tests
    {
        [TestMethod]
        public void Verify_ID_Can_Be_Assigned()
        {
            var tempID = 1234;
            var product = new CustomerAndInventory.Product();

            product.ID = tempID;

            Assert.AreEqual(tempID, product.ID);
        }

        [TestMethod]
        public void Verify_Product_Name_Can_Be_Assigned()
        {
            var tempName = "Online Store Product";
            var product = new CustomerAndInventory.Product();

            product.ProductName = tempName;

            Assert.AreEqual(tempName, product.ProductName);
        }

        [TestMethod]
        public void Verify_Product_Description_Can_Be_Assigned()
        {
            var tempDescription = "This is a product that can do things that it is supposed to do.";
            var product = new CustomerAndInventory.Product();

            product.ProductName = tempDescription;

            Assert.AreEqual(tempDescription, product.ProductName);
        }
    }
}
