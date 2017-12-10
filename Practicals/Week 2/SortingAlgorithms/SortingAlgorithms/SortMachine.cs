using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    //Class to sort array of numbers using one of four methods
    public class SortMachine
    {
        const int MAXNUM = 1000; //Random number range
        const int ONE = 1; //Non literal for one

        Random random;
        public int[] SortArray; //Array to be sorted
        int sortSize; //Value given by user input for length of array

        //User inputs array length
        public SortMachine(int sortSize)
        {
            SortArray = new int[sortSize];
            this.sortSize = sortSize;
            random = new Random();
            FillArray();
        }

        //Populates array with random numbers 
        public void FillArray()
        {
            for (int i = 0; i < sortSize; i++)
                SortArray[i] = random.Next(MAXNUM);
        }

        //Swaps two given numbers between to given array indices
        public void Swap(int pos1, int pos2, int a, int b)
        {
                SortArray[pos2] = a;
                SortArray[pos1] = b;
        }

        public void BubbleSort()
        {
            //Iterates through the for loop the amount of values the array holds minus one
            for (int i = 0; i < sortSize - ONE; i++) 
                for (int j = 0; j < sortSize - ONE; j++) //Iterates through each value in the array comparing two adjacent values
                    if (SortArray[j] > SortArray[j + ONE])
                        Swap(j, j + ONE, SortArray[j], SortArray[j + ONE]); //Will swap the compared values if the first is greater than the last
        }

        public void SelectionSort()
        {
            //Iterates through decending loop to reduce amount of array checked each pass
            for (int i = sortSize - ONE; i > 0; i--)
            {
                int highestNum = 0; //Variable to store the highest value in array range
                int highIndex = 0; //Variable to store the array index of the highest value to give a location for the value to be swapped
                for (int j = 0; j < i + ONE; j++) //Iterates through each remaining unsorted number to get the highest value
                    if (SortArray[j] > highestNum) 
                    {
                        highestNum = SortArray[j]; //If new high number is found it is stored along with its index
                        highIndex = j;
                    }
                if(highIndex != i) //Comparison to prevent unnecessary swapping between the same value and location
                    Swap(i, highIndex, SortArray[i], highestNum); 
            }
        }

        public void InsertionSort()
        {
            int heldNum; //Holds the array value being compared
            int currentNum; //The current index 
            for (int i = ONE; i < sortSize; i++) 
            {
                heldNum = SortArray[i]; //Stores the value where the first number may be shifted to
                currentNum = i - ONE; //
                while (currentNum >= 0 && SortArray[currentNum] > heldNum) //Goes down each array index shifting larger values up until values are no longer larger or 0 index position has been reached
                {
                    //If the next value is less than the current value being compared the current value will be shifted up one space
                    SortArray[currentNum + ONE] = SortArray[currentNum];
                    currentNum--;
                }
                SortArray[currentNum + 1] = heldNum; //Replaces value where the decending while loop ended with the held value 
            }
        }

        public void MergeSort()
        {
            int groupLength = 2; //Sets the length of the initial group length to be sorted
            while (groupLength <= sortSize) //Interates through loop while the group length is not bigger than the array size
            {
                //Initial values set for values to be passed to the merge method
                int low1 = 0; //Set at the start of the first lower bound
                int low2 = groupLength / 2; //set to the start of the second lower bound
                int high1 = 0 + ((groupLength / 2) -1); //set at the upper bounds of the first set
                int high2 = groupLength - 1; //set at the upper bound of second set
                while (low1 < sortSize)
                {
                    MergeArraySegments(SortArray, low1, high1, low2, high2); //Passed values to merge method
                    //Adds the current group length to the variables to be passed into the next set of merges
                    low1 += groupLength; 
                    low2 += groupLength;
                    high1 += groupLength;
                    high2 += groupLength;
                }
                groupLength *= 2; //Doubles the size of the sets
            }
        }

        //Takes indices in an array and merges the two sets given
        public void MergeArraySegments(int[] inputArray, int low1, int high1, int low2, int high2)
        {
            int index1;
            int index2;
            int indexBuffer;
            int[] mergeBuffer = new int[(high2 + ONE) -low1]; // Sets a temporary array to be populated by the sorted comparisons

            index1 = low1;//Takes the lower index of the first set
            index2 = low2;//Takes the lower index of the second given set
            indexBuffer = 0; //Sets a position for the buffer to be populated to

            while ((index1 <= high1) && (index2 <= high2))//Compares the lowest value of each set and puts the lowest into the buffer array
            {
                if (inputArray[index1] <= inputArray[index2])
                {
                    mergeBuffer[indexBuffer] = inputArray[index1];
                    index1++;
                    //If there are no more values left to compare from one of the sets, the remaining values are copied into the remaining spots in the buffer array
                    if (index1 > high1)
                    {
                        indexBuffer++;
                        Array.Copy(inputArray, index2, mergeBuffer, indexBuffer, (high2 - (index2-1)));
                    }
                }
                else
                {
                    mergeBuffer[indexBuffer] = inputArray[index2];
                    index2++;
                    if (index2 > high2)
                    {
                        indexBuffer++;
                        Array.Copy(inputArray, index1, mergeBuffer, indexBuffer, (high1 - (index1 - 1)));
                    }
                }
                indexBuffer++;
            }
            Array.Copy(mergeBuffer, 0, inputArray, low1, mergeBuffer.Length); //buffer array is copied back into the original array                
        }
    }
}
