using System;
class Program {
     //count from n to 50
    public void Recursion(int i)
    {
       if (i >= 50)
       {
        return;
       }
        i++;
        Recursion(i);  
    }
}