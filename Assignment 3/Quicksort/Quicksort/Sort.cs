using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quicksort
{
    //Static class tht implements the quick sort algorithm
    public static class Sort
    {
        //Recursive divide and conquer algorithm that, at each depth, using passed in indicies 
        //to create smaller partitions. Each partition uses a pivot value (in this case the 
        //most left value in the partition and positions the pivot in the correct part of the partition.
        //The indicies from the left of the partition to the pivot value are then passed through 
        //to the recursive method as well as the indices from the pivot point to the right most index of 
        //the current partition, unless there is no indicies to the left and/or right. Partitions are 
        //recursed over until the length of the partition is one.
        
        //Recursive method
        public static void QuickSort(int[] intArray, int left, int right)
        {
                int pivot = partition(intArray, left, right);
                if (left < pivot  - 1)
                    QuickSort(intArray, left, pivot - 1);
                if(right > pivot)
                    QuickSort(intArray, pivot, right);          
        }

        //Takes indicies to create a smaller partition of the array to be sorted. Takes the left value and 
        //sorts it in the correct index of the array. 
        private static int partition(int[] intArray, int left, int right)
        {
            int pivot = intArray[left];
            while(left <= right)
            {
                while(intArray[left] < pivot)
                {
                    left++;
                }

                while(intArray[right] > pivot)
                {
                    right--;
                }
                if (left <= right)
                {
                    swap(intArray, left, right);
                    left++;
                    right--;
                }
            }
            return left;
        }
        
        //Swap method
        private static void swap(int[] intArray, int left, int right)
        {
                int numberHolder = intArray[left];
                intArray[left] = intArray[right];
                intArray[right] = numberHolder;
        }
        
    }
}
