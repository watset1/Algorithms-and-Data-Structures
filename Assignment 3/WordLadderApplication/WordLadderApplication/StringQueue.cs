using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordLadderApplication
{
    public class StringQueue
    {
        StringLinkedList queueList;

        public StringQueue()
        {
            queueList = new StringLinkedList();
        }

        public void Push(List<String> stringToAdd)
        {
            queueList.AddString(stringToAdd);
        }

        public List<String> Pop()
        {
            List<String> PopString;
            try
            {
                PopString = queueList.head.Value;
                queueList.DeleteString(queueList.head);
            }
            catch (NullReferenceException)
            {
                throw new Exception("Attempted to pop from an empty stack");
            }
            return PopString;

        }

        public List<String> Peek()
        {

            List<String> peekString;
            try
            {
                peekString = queueList.head.Value;
            }
            catch (NullReferenceException)
            {
                throw new Exception("Attempted to peek at an empty stack");
            }
            return peekString;
        }

        public int Count()
        {
            return queueList.ListCount();
        }

        public bool IsEmpty()
        {
            if (queueList.ListCount() == 0)
                return true;
            else
                return false;
        }
    }
}
