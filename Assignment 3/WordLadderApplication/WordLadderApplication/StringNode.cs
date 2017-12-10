using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordLadderApplication
{
    public class StringNode
    {
        public StringNode Next { get; set; }
        public List<String> Value { get; set; }

        public StringNode()
        {
            Next = null;
            Value = new List<String>();
        }
    }
}
