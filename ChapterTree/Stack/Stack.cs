/* 
1- initalize the list of shipments
2-craete a stack 
 */
 using System.Collections.Generic;
 public class program {
    List<int> packeg = new List<int>{1,2,3,4}; 
    public void recursion(int i){
        if (i == packeg.Count)
        {
            return;
        }
        Console.WriteLine(packeg[i]);
         recursion(i+1);
    }
    
 }