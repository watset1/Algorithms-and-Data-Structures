using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quicksort
{
    public class SortManager
    {
        const int MAX_INTEGER_SIZE = 1000;
        const String SORTED = "Sorted";
        const String UNSORTED = "Unsorted";
        Random random;

        public SortManager()
        {
            random = new Random();
        }
        
        //Calls static quicksort method and displays the sorted and unsorted arrays
        public void Quicksort(int setSize, ListBox unsortedDisplay, RichTextBox sortedDisplay)
        {
            int[] intArray = new int[setSize];
            fillArray(intArray);
            unsortedDisplay.Items.Add(UNSORTED);
            displayArray(intArray, unsortedDisplay);
            Sort.QuickSort(intArray, 0, setSize - 1);
            sortedDisplay.AppendText(SORTED + "\n");
            displayArray(intArray, sortedDisplay);
        }

        //Populates the array
        private void fillArray(int[] intArray)
        {
            for (int index = 0; index < intArray.Length; index++)
            {
                int rGen = random.Next(MAX_INTEGER_SIZE);
                intArray[index] = rGen;
            }
        }

        //Displays an array in a given control (listbox or rich text box)
        private void displayArray(int[] intArray, Control displayBox)
        {
            if (displayBox is ListBox)
                foreach (int number in intArray)
                    ((ListBox)displayBox).Items.Add(number);
            else
                foreach (int number in intArray)
                    ((RichTextBox)displayBox).AppendText(number.ToString() + "\n");
        }
    }
}
