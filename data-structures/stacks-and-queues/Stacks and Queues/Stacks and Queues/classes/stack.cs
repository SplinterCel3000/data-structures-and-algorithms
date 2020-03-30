using System;
using System.Collections.Generic;
using System.Text;
using Stacks_and_Queues.classes; 

namespace Stacks_and_Queues.classes
{
   public class stack
    {
        public node Top { get; set; }

        public int pop()
        {
           
            try
            {
                node oldTop = Top;

                Top = Top.Next;

                oldTop.Next = null;

                return oldTop.Value;
            }
            catch (Exception)
            {

                throw new Exception(" This didnt work");
            }
        }

       public void push(int value)
        {
            node oldTop = Top;
            Top = new node { Value = value };
            Top.Next = oldTop; 
            
        }

        public bool isEmpty()
        {
            return Top == null; 
        }

        public int peek(int value)
        {
            try
            {
                return Top.Value;
            }
            catch (Exception)
            {

                throw new Exception("this didnt work??");
            }
        
        }
    }
}
