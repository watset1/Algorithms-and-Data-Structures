using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    public class RecursionMachine
    {
        public RecursionMachine() { }

        public String ReverseIt(String inputString)
        {
            if (inputString.Length == 1)
                return inputString;
            else
                return inputString[inputString.Length -1] + ReverseIt(inputString.Substring(0, inputString.Length - 1));
        }

        public int SumToN(int inputNumber)
        {
            if (inputNumber == 1)
                return 1;
            return SumToN(inputNumber - 1) + inputNumber;
        }

        public bool Palindrome(String inputString)
        {
            if (inputString.Length == 0 || inputString.Length == 1) //Checks for even and odd input length
                return true;
            if (inputString[0] != inputString[inputString.Length - 1]) //Checks both ends of string to see if they are not the same
                return false; //Will only return a false if matches arent found
            return Palindrome(inputString.Substring(1, inputString.Length - 2)); //recursive function takes inner value of values checked
        }

        public String RemoveIt(String targetChar, String inputString)
        {
            if (inputString.Length == 0)//Returns nothing when inputString has no length
                return "";

            String currentCharacter = inputString[0].ToString();//Gets the first character in the current inputString
            if (currentCharacter == targetChar) //Checks against the target character
                currentCharacter = ""; //"Nulls" the string if target character is found

            return currentCharacter + RemoveIt(targetChar, inputString.Substring(1, inputString.Length - 1));//Appends string to the front of the return string
        }

        public void MergeSort(int[] unmergedArray, int lowIndex, int highIndex)
        {
            int setSize = highIndex - lowIndex;//gets current set size
            if (setSize > 1) //base case - will recurse as long as merging set is 2 or more
            {
                int midIndex = (highIndex + lowIndex) / 2; //sets the midpoint between the two bounds
                MergeSort(unmergedArray, lowIndex, midIndex); //adds the lower half of current array bounds to the stack
                MergeSort(unmergedArray, midIndex, highIndex);//adds the higher half of the current array bounds to the stack
                MergeArraySegments(unmergedArray, lowIndex, midIndex - 1, midIndex, highIndex - 1); //Merges the two halfs
            }
        }

        public void MergeArraySegments(int[] inputArray, int low1, int high1, int low2, int high2)
        {
            int index1;
            int index2;
            int indexBuffer;
            int[] mergeBuffer = new int[(high2 + 1) - low1]; // Sets a temporary array to be populated by the sorted comparisons

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
                        Array.Copy(inputArray, index2, mergeBuffer, indexBuffer, (high2 - (index2 - 1)));
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

        public bool BinarySearch(int[] dataValues, int target, int lowerBound, int upperBound)
        {
            if (upperBound - lowerBound == 1)//Sets base class as the last possible nimber to check
                return false;

            int midPoint = (upperBound + lowerBound) / 2; //sets the nearest whole number between the town bounds as the midpoint
            if (dataValues[midPoint] > target) //If midpoint is higher than target midpoint becomes new upperBound
                return BinarySearch(dataValues, target, lowerBound, midPoint);
            if (dataValues[midPoint] < target) //If midpoint is lower than target midpoint becomes new lowerBound
                return BinarySearch(dataValues, target, midPoint, upperBound);
            if (dataValues[midPoint] == target) //If neither above conditions are met the current midpoint is checked
                return true; //Returns true if target is found, and false if it doesnt exist
            else
                return false;
        }
    }
}
