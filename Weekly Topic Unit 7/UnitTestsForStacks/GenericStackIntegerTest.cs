using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;

namespace UnitTestsForStacks
{
    [TestClass]
    public class GenericStackIntegerTest
    {
        public void Method1()
        {
            var myStack = new Stack<int>();

            var myStackArray = myStack.ToArray();
        }

        [TestMethod]
        public void Push_And_Pop_Values()
        {
            var myStack = new Stack<int>();

            myStack.Push(111);
            myStack.Push(222);
            myStack.Push(333);
            myStack.Push(444);
            myStack.Push(555);

            myStack.Count.ShouldBe(5);

            var test1 = myStack.Peek();
            test1.ShouldBe(555);

            var test2 = myStack.Pop();
            test2.ShouldBe(555);

            var test3 = myStack.Peek();
            test3.ShouldBe(444);

            myStack.Count.ShouldBe(4);

            myStack.Pop();
            myStack.Pop();

            myStack.Count.ShouldBe(2);

            var test4 = myStack.Pop();
            test4.ShouldBe(222);

            var test5 = myStack.Pop();
            test5.ShouldBe(111);

            myStack.Count.ShouldBe(0);

        }

        [TestMethod]
        public void Array_Test()
        {
            var myStack = new Stack<int>();

            myStack.Push(111);
            myStack.Push(222);
            myStack.Push(333);
            myStack.Push(444);
            myStack.Push(555);

            myStack.Count.ShouldBe(5);

            var myStackArray = myStack.ToArray();
            myStackArray.ShouldBeOfType<int[]>();
            myStackArray[0].ShouldBe(555);
            myStackArray[1].ShouldBe(444);
            myStackArray[2].ShouldBe(333);
            myStackArray[3].ShouldBe(222);
            myStackArray[4].ShouldBe(111);
        }

    }
}
