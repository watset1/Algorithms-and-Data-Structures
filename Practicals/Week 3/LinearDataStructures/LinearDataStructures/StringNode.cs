using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearDataStructures
{
    public class StringNode
    {
        public StringNode Next { get; set; }
        public String Value { get; set; }

        public StringNode()
        {
            Next = null;
            Value = null;
        }
    }
}
