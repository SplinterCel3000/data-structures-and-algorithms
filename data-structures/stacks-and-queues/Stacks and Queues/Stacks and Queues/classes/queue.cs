using System;
using System.Collections.Generic;
using System.Text;

namespace Stacks_and_Queues.classes
{
   public class queue
    {
        public node front { get; set;  }

        private node rear { get; set; }

        public void enqueue(int value)
        {
            node thing = new node{ Value = value};

            if (front != null)
            {
                rear.Next = thing;
            }

            else
            {
                front = thing; 
            }
            rear = thing; 
        }

        public int dequeue()
        {
            try
            {
               node oldFront = front;
               front = front.Next;
               oldFront.Next = null;

                return oldFront.Value;

            }
            catch (Exception)
            {

                throw new Exception("queue is empty");
            }
        }
        public int peek()
        {
            try
            {
                return front.Value;
            }
            catch (Exception)
            {

                throw new Exception("its is empty");
            }
        }

        public bool isEmpty()
        {
            return (front == null);
        }
    }
}
