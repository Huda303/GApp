/*the idea of the merge sort is to divide the array into two parts
the left part is less than the right one (if the array is even each part
have the same amount of elements but if it was odd the left side will be bigger)
than reorder the array*/
using System;

class MergeAlgorithm
{
   public static void MergeSort(int[] array, int left, int right)
    {
        if (left < right)
        {
            // Find the middle point
            int middle = (left + right) / 2;

            // Recursively sort the first and second halves
            MergeSort(array, left, middle);
            MergeSort(array, middle + 1, right);

            // Merge the sorted halves
            Merge(array, left, middle, right);
        }
    }
    public static void Merge(int[] array, int left, int middle, int right)
    {
        // Sizes of two subarrays to be merged
        int leftSize = middle - left + 1;
        int rightSize = right - middle;

        // Temporary arrays to hold the data
        int[] leftArray = new int[leftSize];
        int[] rightArray = new int[rightSize];

        // Copy data to temporary arrays
        Array.Copy(array, left, leftArray, 0, leftSize);
        Array.Copy(array, middle + 1, rightArray, 0, rightSize);

        int i = 0, j = 0, k = left;

        // Merge the temp arrays back into the original array
        while (i < leftSize && j < rightSize)
        {
            if (leftArray[i] <= rightArray[j])
            {
                array[k] = leftArray[i];
                i++;
            }
            else
            {
                array[k] = rightArray[j];
                j++;
            }
            k++;
        }

        // Copy any remaining elements of leftArray
        while (i < leftSize)
        {
            array[k] = leftArray[i];
            i++;
            k++;
        }

        // Copy any remaining elements of rightArray
        while (j < rightSize)
        {
            array[k] = rightArray[j];
            j++;
            k++;
        }
    }
}
