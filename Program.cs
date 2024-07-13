// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using ChapterFive;

//using Grokking_Algorithm.Chapter_2;

namespace HelloWorld
{
  internal class Program
  {
    public static void Main(string[] args)
    {       //Binary search
            //Exercises.StepCounter();
            //linked list
            // var linked = new LinkedList();
            // linked.AddBack(1);
            // linked.AddBack(2);
            // linked.AddBack(3);
            // linked.AddBack(4);
            // linked.Display();
            //program ship = new program();
            //ship.recursion(0);
             //Stack<int> p = new Stack<int>(5); 
             //p.Push(10); 
             //p.Push(20); 
             //p.Push(30); 
             //p.Display(); 
             //p.Pop(); 

             //quick sort algorithm
              //  int[] arr = [3, 6, 8, 10, 1, 2, 1];
              //  QuickSortAlgorithm.QuickSort(arr,0,arr.Length-1);     
              //  for (int i = 0; i < arr.Length; i++)
              //    {
              //      Console.Write(arr[i] + " ");
              //    }


              //merge sort algorithm
              // Define an array of integers to be sorted
        //int[] array = { 34, 7, 23, 32, 5, 62 };
        //Console.WriteLine("Original array: " + string.Join(" ", array));

        // Call MergeSort on the entire array
        //MergeAlgorithm.MergeSort(array, 0, array.Length - 1);

        // Print the sorted array
       //Console.WriteLine("Sorted array: " + string.Join(" ", array));
      


        HashCountry HM = new HashCountry();
            HM.Set("Iraq", 35.525, 24.242);
            HM.Set("iran", 5.5, 4.22);
            Console.WriteLine(HM.Get("iran").lang);

  }
 
}
}