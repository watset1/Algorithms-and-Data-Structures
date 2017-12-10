using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic_Algorithms
{
    public class Item
    {
        public int ItemNumber { get; set; }
        public int Value { get; set; }
        public int Weight { get; set; }

        public Item(int itemNumber, int value, int weight)
        {
            ItemNumber = itemNumber;
            Value = value;
            Weight = weight;
        }
    }
}
