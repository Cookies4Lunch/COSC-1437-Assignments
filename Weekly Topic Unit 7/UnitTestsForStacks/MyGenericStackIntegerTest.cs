using System;
using System.Collections;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;
using MyGenericStack;



namespace UnitTestsForStacks
{
    [TestClass]
    public class MyGenericStackIntegerTest
    {
        [TestMethod]
        public void Push_And_Pop_Values()
        {
            var myStack = new MyStack<int>();

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
    }
}
