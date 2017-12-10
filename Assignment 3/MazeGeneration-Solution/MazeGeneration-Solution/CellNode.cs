using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGeneration_Solution
{
    //Holds a cell and its linked cells for use in stack
    public class CellNode
    {
        public CellNode Next { get; set; }
        public Cell Value { get; set; }

        public CellNode()
        {
            Next = null;
            Value = null;
        }

        public CellNode(Cell cell)
        {
            Next = null;
            Value = cell;
        }
    }
}
