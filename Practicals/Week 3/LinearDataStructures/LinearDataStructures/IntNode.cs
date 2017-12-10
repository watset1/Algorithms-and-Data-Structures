using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearDataStructures
{
    public class IntNode
    {
        public IntNode Next { get; set; }
        public int Value { get; set; }

        public IntNode()
        {
            Next = null;
            Value = 0;
        }
    }
}
