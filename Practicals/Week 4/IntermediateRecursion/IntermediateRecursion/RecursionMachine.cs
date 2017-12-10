using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntermediateRecursion
{
    public class RecursionMachine
    {
        int[] intArray;
        public List<String> integerList { get; set; }

        public RecursionMachine() 
        {
            integerList = new List<String>();
            intArray = new int[4];
        }

        public bool PowerOfThree(double n)
        {
            if (n == 1 || n % 1 != 0)
                if (n == 1)
                    return true;
                else
                    return false;            
            return PowerOfThree(n / 3); 
        }
    }
}
