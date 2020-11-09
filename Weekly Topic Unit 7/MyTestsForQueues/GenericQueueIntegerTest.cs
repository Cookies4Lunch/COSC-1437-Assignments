using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;
using System.Collections;
using System.Collections.Generic;

namespace MyTestsForQueues
{
    [TestClass]
    public class GenericQueueIntegerTest
    {
        [TestMethod]
        public void Enqueue_And_Dequeue_Values()
        {
            var myQueue = new Queue<int>();

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

        [TestMethod]
        public void Array_Test()
        {
            var myQueue = new Queue<int>();

            myQueue.Enqueue(111);
            myQueue.Enqueue(222);
            myQueue.Enqueue(333);
            myQueue.Enqueue(444);
            myQueue.Enqueue(555);

            myQueue.Count.ShouldBe(5);

            var myQueueArray = myQueue.ToArray();
            myQueueArray.ShouldBeOfType<int[]>();
            myQueueArray[0].ShouldBe(111);
            myQueueArray[1].ShouldBe(222);
            myQueueArray[2].ShouldBe(333);
            myQueueArray[3].ShouldBe(444);
            myQueueArray[4].ShouldBe(555);
        }
    }
}
