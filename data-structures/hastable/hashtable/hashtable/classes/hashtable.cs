using System;
using System.Collections.Generic;
using System.Text;

namespace hashtable.classes
{
    class hashtable
    {

        private LinkedList<string[]>[] lists { get; set; }

        public hashtable(int lenght) 
        {
            lists = new LinkedList<string[]>[lenght];
        }

        public int Hash(string key)
        {
            char[] chars = key.ToCharArray();
            long product = 1;
            foreach(char i in chars)
            {
                product *= (int)i;
            }
            return(int)(Math.Abs(product) % lists.Length);
        }

        public void add(string key, string value) 
        {
            string[] things = new string[] { key, value };
            int idx = Hash(key);

            if (lists[idx] == null)
                lists[idx] = new LinkedList<string[]>();
            lists[idx].AddLast(things);
        }

        public string Get(string key)
        {
            int idx = Hash(key);
            if (lists[idx] == null)
                return null;
            LinkedListNode<string[]> current = lists[idx].First;
            while (current.Value[0] != key && current != null)
                current = current.Next;
            if (current != null)
                return current.Value[1];
            else
                return null;
        }

        public bool contains(string key)
        {
            int idx = Hash(key);
            if (lists[idx] == null)
                return false;
            LinkedListNode<string[]> current = lists[idx].First;
            while (current.Value[0] != key && current != null)
                current = current.Next;
            if (current != null)
                return true;
            else
                return false;
        }
    }
}
