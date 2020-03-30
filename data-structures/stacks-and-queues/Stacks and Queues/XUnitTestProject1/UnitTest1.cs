using System;
using Xunit;
using Stacks_and_Queues.classes;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void CanPushToStack()
        {
            stack bagels = new stack();
            bagels.push(3);

            Assert.Equal(3, bagels.Top.Value);
        }
        [Fact]
        public void CanPushToMultipleThingsStack()
        {
            stack sticks = new stack();
            sticks.push(2);
            sticks.push(4);

            Assert.Equal(4, sticks.Top.Value);
        }

        [Fact]
        public void CanPopOffStack()
        {
            stack videogames = new stack();
            videogames.push(2);
            videogames.push(3);
            videogames.pop();

            Assert.Equal(2, videogames.Top.Value);
        }

        [Fact]
        public void CanEmptyStacksWithPops()
        {
            stack crayons = new stack();
            crayons.push(5);
            crayons.push(4);
            crayons.pop();
            crayons.pop();

            Assert.Null(crayons.Top);
        }

        [Fact]
        public void CanPeekNextValueStack()
        {
            stack cake = new stack();
            cake.push(2);
            cake.push(3);

            Assert.Equal(3, cake.peek());
        }

        [Fact]
        public void CreateEmptyStack()
        {
            stack empty = new stack();
            Assert.Null(empty.Top);
        }

        [Fact]
        public void PeekExceptions()
        {
            stack broken = new stack();
            Assert.Throws<System.IndexOutOfRangeException>(() => broken.peek());
        }

        [Fact]
        public void PopExceptions()
        {
            stack broken = new stack();
            Assert.Throws<System.Exception>(() => broken.pop());
        }

        [Fact]
        public void CanEnqueueValue()
        {
            queue lines = new queue();
            lines.enqueue(1);

            Assert.Equal(1, lines.front.Value);
        }

        [Fact]
        public void CanEnqueueMultipleValues()
        {
            queue moreLines = new queue();
            moreLines.enqueue(1);
            moreLines.enqueue(3);

            Assert.True(moreLines.front.Value == 1 && moreLines.front.Next.Value == 3);
        }

        [Fact]
        public void CanDequeue()
        {
            queue jambaJuice = new queue();
            jambaJuice.enqueue(2);
            Assert.True(2 == jambaJuice.dequeue() && jambaJuice.front == null);
        }

        [Fact]
        public void CanPeekNextInQueue()
        {
            queue superMarket = new queue();
            superMarket.enqueue(20);

            Assert.Equal(20, superMarket.peek());
        }

        [Fact]
        public void CanEmptyWithDequeue()
        {
            queue done = new queue();
            done.enqueue(1);
            done.enqueue(2);
            done.dequeue();
            done.dequeue();

            Assert.Null(done.front);

        }

        [Fact]
        public void CanInstantiateEmptyQueue()
        {
            queue iceCream = new queue();
            Assert.Null(iceCream.front);
        }

        [Fact]
        public void DequeueThrowException()
        {
            queue thisLine = new queue();
            Assert.Throws<System.Exception>(() => thisLine.dequeue());
        }

        [Fact]
        public void PeekThrowException()
        {
            queue thisLine = new queue();
            Assert.Throws<System.Exception>(() => thisLine.peek());
        }
    }
}
