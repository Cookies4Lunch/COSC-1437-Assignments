using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;
using System.Collections;
using System.Collections.Generic;
using MyGenericQueues;

namespace MyTestsForQueues
{
    [TestClass]
    public class MyGenericQueueIntegerTest
    {
        [TestMethod]
        public void Enqueue_And_Dequeue_Values()
        {
            var myQueue = new MyQueue<int>();

            myQueue.Enqueue(111);
            myQueue.Enqueue(222);
            myQueue.Enqueue(333);
            myQueue.Enqueue(444);
            myQueue.Enqueue(555);

            myQueue.Count.ShouldBe(5);

            var test1 = myQueue.Peek();
            test1.ShouldBe(111);

            var test2 = myQueue.Dequeue();
            test2.ShouldBe(111);

            var test3 = myQueue.Peek();
            test3.ShouldBe(222);

            myQueue.Count.ShouldBe(4);

            myQueue.Dequeue();
            myQueue.Dequeue();

            myQueue.Count.ShouldBe(2);

            var test4 = myQueue.Dequeue();
            test4.ShouldBe(444);

            var test5 = myQueue.Dequeue();
            test5.ShouldBe(555);

            myQueue.Count.ShouldBe(0);

        }

        
    }
}
