using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Classes
{
    public class Linklist
    {
        public Node Head { get; set; }
        private Node Current { get; set; }


        // insert method
        /// <summary>
        /// This is instantiating a new node, setting value to whats inputed and set next to head. 
        /// </summary>
        /// <param name="value"></param>
        public void Insert(int value)
        {
            // instantiate a new Node 
            Node node = new Node();
            // set value to the inputted data
            node.Value = value;
            // set next to head
            node.Next = Head;

            //set that(new node) as the head
            Head = node;
        }

        // includes method
        /// <summary>
        /// This will make sure that it includes a value at all if not it moves on. 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool Includes(int value)
        {
            // set c = h
            Current = Head;

            while (Current != null)
            {
                // check if value is equal
                if (Current.Value == value)
                {
                    return true;
                }

                // go to next node
                Current = Current.Next;

            }

            return false;
        }

        /// <summary>
        /// This will append the current value to the head. 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            Current = Head;
            StringBuilder sb = new StringBuilder();
            while (Current != null)
            {
                sb.Append($"{Current.Value} -> ");
                Current = Current.Next;
            }

            // we are at null at this point
            sb.Append("NULL");
            return sb.ToString();
        }

        public void append()
        {

        }


    }
}
