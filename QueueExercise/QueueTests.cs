using System;
using NUnit.Framework;

namespace QueueExercise
{
    [TestFixture]
    public class QueueTests
    {
        private Queue queue;

        [SetUp]
        public void SetUp()
        {
            queue = new Queue();
        }

        [Test]
        public void NewQueue_CreatesEmptyQueue()
        {
            Assert.AreEqual(0, queue.Size());
        }

        [Test]
        public void AfterPushingOneElement_SizeIsOne()
        {
            queue.Push(0);
            Assert.AreEqual(1, queue.Size());
        }

        [Test]
        public void PopAfterPush_SizeIsZero()
        {
            queue.Push(0);
            queue.Pop();
            Assert.AreEqual(0, queue.Size());
        }

        [Test]
        public void PopAfterPush_ReturnsSameElement()
        {
            queue.Push(0);
            int element = queue.Pop();
            Assert.AreEqual(0, element);
        }

        [Test]
        public void TwoPopsAfterTwoPushes_SizeIsZero()
        {
            queue.Push(5);
            queue.Push(10);
            int element = queue.Pop();
            element = queue.Pop();
            Assert.AreEqual(0, queue.Size());
        }

        [Test]
        [ExpectedException(typeof(Queue.UnderflowException))]
        public void PopWhenEmptyQueue_ThrowsUnderflowException()
        {
            queue.Pop();
        }

        [Test]
        public void TwoPopsAfterTwoPushes_ReturnsElementsInPushedOrder()
        {
            queue.Push(5);
            queue.Push(10);
            int element = queue.Pop();
            Assert.AreEqual(5, element);
            element = queue.Pop();
            Assert.AreEqual(10, element);
        }

        [Test]
        [ExpectedException(typeof(Queue.OverflowException))]
        public void MultiplePushesBeyondMaxSize_ThrowsOverflowException()
        {
            queue.Push(5);
            queue.Push(10);
            queue.Push(20);
            queue.Push(40);
        }

        [Test]
        public void MultiplePopsAndPushes()
        {
            queue.Push(5);
            queue.Push(10);
            queue.Push(20);

            int element = queue.Pop();
            Assert.AreEqual(5, element);
            element = queue.Pop();
            Assert.AreEqual(10, element);
            element = queue.Pop();
            Assert.AreEqual(20, element);

            queue.Push(30);
            element = queue.Pop();
            Assert.AreEqual(30, element);

            queue.Push(10);
            queue.Push(20);
            element = queue.Pop();
            Assert.AreEqual(10, element);
            element = queue.Pop();
            Assert.AreEqual(20, element);
        }

    }

    public class Queue
    {
        private static int MAX_SIZE = 3;
        private int[] elements = new int[MAX_SIZE];
        private int size;
        private int queueFront;
        private int queueBack;

        public int Size()
        {
            return size;
        }

        public void Push(int i)
        {
            if (size == MAX_SIZE)
                throw new OverflowException();

            size++;

            elements[queueBack++ % MAX_SIZE] = i;
        }

        public int Pop()
        {
            if (size == 0)
                throw new UnderflowException();

            --size;
            return elements[queueFront++ % MAX_SIZE];
        }

        public class UnderflowException : Exception
        {
        }

        public class OverflowException : Exception
        {
        }
    }
}
