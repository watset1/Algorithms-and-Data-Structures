using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermutationPractical
{
    public class PermutationAlgorithm
    {
        public List<String> intToStringArray { get; set; }
        int[] intArray;

        public PermutationAlgorithm(int startPoint, int n)
        {
            intToStringArray = new List<String>();
            intArray = new int[n];
            Permutations(startPoint, n);
        }

        public void Permutations(int startPoint, int n)
        {
            if (startPoint == n)
                ConvertIntArray(n);
            else
                for (int i = 1; i < n + 1; i++)
                {
                    intArray[startPoint] = i;
                    Permutations(startPoint + 1, n);
                }
        }

        public void ConvertIntArray(int n)
        {
            String arrayString = "";
            for (int i = 0; i < intArray.Length; i++)
                arrayString += intArray[i];
            intToStringArray.Add(arrayString);
        }        
    }
}
