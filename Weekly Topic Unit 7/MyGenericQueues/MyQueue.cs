using System;

namespace MyGenericQueues
{
    /// <summary>
    /// A Last In First Out (LIFO) collection implemented as a linked list.
    /// </summary>
    /// <typeparam name="T">The type of item contained in the stack</typeparam>
    public class MyQueue<T> : System.Collections.Generic.IEnumerable<T>
    {
        private System.Collections.Generic.LinkedList<T> _list =
            new System.Collections.Generic.LinkedList<T>();

        /// <summary>
        /// Adds the specified item to the end of the queue
        /// </summary>
        /// <param name="item">The item</param>
        public void Enqueue(T item)
        {
            _list.AddLast(item);
        }

        /// <summary>
        /// Removes and returns the last item from the queue
        /// </summary>
        /// <returns>The last item in the queue</returns>
        public T Dequeue()
        {
            if (_list.Count == 0)
            {
                throw new InvalidOperationException("The queue is empty");
            }

            T value = _list.Last.Value;
            _list.RemoveLast();

            return value;
        }

        /// <summary>
        /// Returns the last item of the queue without removing it
        /// </summary>
        /// <returns>The last item in queue</returns>
        public T Peek()
        {
            if (_list.Count == 0)
            {
                throw new InvalidOperationException("The stack is empty");
            }

            return _list.Last.Value;
        }

        /// <summary>
        /// The current number of items in the queue
        /// </summary>
        public int Count
        {
            get
            {
                return _list.Count;
            }
        }

        /// <summary>
        /// Removes all items from the queue
        /// </summary>
        public void Clear()
        {
            _list.Clear();
        }

        /// <summary>
        /// I was not sure how to change this for a queue
        /// </summary>
        /// <returns>The LIFO enumerator</returns>
        public System.Collections.Generic.IEnumerator<T> GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        /// <summary>
        /// I was not sure how to change this for a queue
        /// </summary>
        /// <returns>The LIFO enumerator</returns>
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _list.GetEnumerator();
        }
    }
}
