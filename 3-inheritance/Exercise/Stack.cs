using System;
using System.Collections;

namespace Exercise
{
    partial class Program
    {
        public class Stack
        {
            private ArrayList list = new ArrayList();

            public void Push(object obj)
            {
                if(obj == null)
                {
                    throw new InvalidOperationException("Cannot push null reference.");
                }

                list.Add(obj);
            }

            public object Pop() 
            {
                if (list.Count == 0) 
                {
                    throw new InvalidOperationException("Cannot pop the empty stack.");
                }

                var lastIndex = list.Count - 1;
                var lastAddedItem = list[lastIndex];
                list.RemoveAt(lastIndex);

                return lastAddedItem;
            }

            public void Clear() 
            {
                list.Clear();
            }
        }
    }
}
