using BinaryTreeImplementation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;
using System.Collections.Specialized;
using System.Linq;

/*
 * ProfReynolds
 */

namespace BinaryTreeTests
{
    [TestClass]
    public class EnumerationTests
    {
        [TestMethod]
        public void Enumerator_Of_Single()
        {
            BinaryTree<int> tree = new BinaryTree<int>();

            foreach (int item in tree)
            {
                Assert.Fail("An empty tree should not enumerate any values");
            }

            //Assert.IsFalse(tree.Contains(10), "Tree should not contain 10 yet");

            tree.Contains(10).ShouldBeFalse("Tree should not contain 10 yet");

            tree.Add(10);

            //Assert.IsTrue(tree.Contains(10), "Tree should contain 10");

            tree.Contains(10).ShouldBeTrue("Tree should contain 10");

            int count = 0;
            foreach (int item in tree)
            {
                count++;
                //Assert.AreEqual(1, count, "There should be exactly one item");
                count.ShouldBe(1, "There should be exactly");
                //Assert.AreEqual(item, 10, "The item value should be 10");
                item.ShouldBe(10, "The item value should be 10");
            }
        }

        [TestMethod]
        public void InOrder_Enumerator()
        {
            BinaryTree<int> tree = new BinaryTree<int>();

            //        4
            //       / \
            //      2   5
            //     / \   \
            //    1   3   7
            //           / \
            //          6   8

            tree.Add(4);
            tree.Add(5);
            tree.Add(2);
            tree.Add(7);
            tree.Add(3);
            tree.Add(6);
            tree.Add(1);
            tree.Add(8);

            int[] expected = new[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            int index = 0;

           

            foreach (int actual in tree)
            {
                //Assert.AreEqual(expected[index++], actual, "The item enumerated in the wrong order");
                actual.ShouldBe(expected[index++], "The item enumerated in the wrong order");
            }
        }


        [TestMethod]
        public void InOrder_Delegate()
        {
            BinaryTree<int> tree = new BinaryTree<int>();

            //        4
            //       / \
            //      2   5
            //     / \   \
            //    1   3   7
            //           / \
            //          6   8

            tree.Add(4);
            tree.Add(5);
            tree.Add(2);
            tree.Add(7);
            tree.Add(3);
            tree.Add(6);
            tree.Add(1);
            tree.Add(8);

            int[] expected = new[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            int index = 0;

            tree.InOrderTraversal(item => 
                item.ShouldBe(expected[index++], "The item enumerated in the wrong order"));
        }

        [TestMethod]
        public void PreOrder_Delegate()
        {
            BinaryTree<int> tree = new BinaryTree<int>();

            //        4
            //       / \
            //      2   5
            //     / \   \
            //    1   3   7
            //           / \
            //          6   8

            tree.Add(4);
            tree.Add(5);
            tree.Add(2);
            tree.Add(7);
            tree.Add(3);
            tree.Add(6);
            tree.Add(1);
            tree.Add(8);

            int[] expected = new[] { 4, 2, 1, 3, 5, 7, 6, 8 };

            int index = 0;

            tree.PreOrderTraversal(item => 
                item.ShouldBe(expected[index++], "The item enumerated in the wrong order"));
        }

        [TestMethod]
        public void PostOrder_Delegate()
        {
            BinaryTree<int> tree = new BinaryTree<int>();

            //        4
            //       / \
            //      2   5
            //     / \   \
            //    1   3   7
            //           / \
            //          6   8

            tree.Add(4);
            tree.Add(5);
            tree.Add(2);
            tree.Add(7);
            tree.Add(3);
            tree.Add(6);
            tree.Add(1);
            tree.Add(8);

            int[] expected = new[] { 1, 3, 2, 6, 8, 7, 5, 4 };

            int index = 0;

            tree.PostOrderTraversal(item => item.ShouldBe(expected[index++], "The item enumerated in the wrong order"));
        }

        [TestMethod]
        public void Remove_Test_Method()
        {
            BinaryTree<int> tree = new BinaryTree<int>();

            //        4
            //       / \
            //      2   5
            //     / \   \
            //    1   3   7
            //           / \
            //          6   8

            tree.Add(4);
            tree.Add(5);
            tree.Add(2);
            tree.Add(7);
            tree.Add(3);
            tree.Add(6);
            tree.Add(1);
            tree.Add(8);

            tree.Remove(1);

            int[] expected = new[] {3, 2, 6, 8, 7, 5, 4 };

            int index = 0;

            tree.PostOrderTraversal(item => item.ShouldBe(expected[index++], "The item enumerated in the wrong order"));
        }

        [TestMethod]
        public void Another_Test_Sortation()
        {
            BinaryTree<int> tree = new BinaryTree<int>();

            int[] values2Start = new[] { 4, 2, 1, 3, 8, 6, 7, 5 };

            foreach (int i in values2Start)
            {
                tree.Add(i);
            }

            // link statement used to sort (order) a LINQ collection and place it into an array

            var expectedResult = values2Start.OrderBy(item => item).ToArray();
            //int[] expectedResult = { 1, 2, 3, 4, 5, 6, 7, 8 };

            // need to now compare the values2Start (use foreach to iterate) vs expectedValues (use direct reference [] rather than iterator)

            int index = 0;

            tree.InOrderTraversal(item =>
                item.ShouldBe(expectedResult[index++], "The item enumerated in the wrong order"));


        }

    }
}
