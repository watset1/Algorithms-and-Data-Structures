using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearDataStructures
{
    public class IntStack
    {
        IntLinkedList stackList;       

        public IntStack()
        {
            stackList = new IntLinkedList();
        }

        public void Push(int intToAdd)
        {
            stackList.AddInt(intToAdd);
        }

        public int Pop()
        {
            int PopInt;
            try
            {
                PopInt = stackList.tail.Value;
                stackList.DeleteInt(stackList.tail);           
            }
            catch(NullReferenceException)
            {
                throw new Exception("Attempted to pop from an empty stack");
            }
            return PopInt;
            
        }

        public int Peek()
        {
            
            int peekInt;
            try
            {
                peekInt = stackList.tail.Value;
            }
            catch(NullReferenceException)
            {
                throw new Exception ("Attempted to peek at an empty stack");
            }
            return peekInt;
        }

        public int Count()
        {
           return stackList.ListCount();
        }

        public bool IsEmpty()
        {
            if (stackList.ListCount() == 0)
                return true;
            else
                return false;
        }
    }
}
