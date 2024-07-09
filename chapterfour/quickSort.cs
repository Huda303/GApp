
/*array of numbers will be saprited into left and right .
We should check that's the left side is less than the right side also swapping between the numbers to reorder them,
At the same time we are comparing these numbers to the (pivot) which it will be the partition point*/
using System.Data;

 class QuickSortAlgorithm{
    public static void QuickSort(int[] array, int left, int right)
    {
        //if left < right will get the pivot index and partiton the array;
        if(left < right)
        {
            int Index = Partiton(array,left,right);
            //sorting the array again
            QuickSort(array, left, Index - 1);
            QuickSort(array, Index + 1, right);
        }
    }
        static int Partiton(int[] array, int left, int right)
        {
            //the right most number in the array will be the pivot
            int pivot = array[right];

            // i will point to the first number in the array after the loop start
            int index = left - 1;

            // reorder the array 
            for (int i = left; i < right; i++)
                 {
                     if (array[i] <= pivot)
                     {
                         index++;
                         Swap(array, i, index);
                     }
                 }
             // place the pivot in the correct position
             index++;
             Swap(array, index, right);
             return index;
        }
        static void Swap(int[] array, int a, int b)
        {
            int temp = array[a];
            array[a] = array[b];
            array[b] = temp;
        }
    }