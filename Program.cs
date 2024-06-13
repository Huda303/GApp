// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using Grokking_Algorithm.Chapter_2;

namespace HelloWorld
{
  internal class Program
  {
    public static void Main(string[] args)
    {       //Binary search
            Exercises.StepCounter();
            //linked list
            var linked = new LinkedList();
            linked.AddBack(1);
            linked.AddBack(2);
            linked.AddBack(3);
            linked.AddBack(4);
            linked.Display();
    }
  }
 
}