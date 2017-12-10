using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuffmanCoding
{
    //Node class holding a symbol and frequency
    public class HuffmanNode
    {
        public HuffmanNode leftChild;
        public HuffmanNode rightChild;
        public String Symbol { get; set; }
        public int Frequency { get; set; }

        public HuffmanNode(String symbol, int frequency)
        {
            Symbol = symbol;
            Frequency = frequency;
            //Initial null children
            leftChild = null;
            rightChild = null;
        }
    }
}
