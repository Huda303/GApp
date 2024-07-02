using System;
class Program2 {
     
    public int Recursion(int n)
    {
        int i = 1;
        int sum;
        if (n == 1)
        {
            return 1;
        }
        // i الرقم المعطى نجمعه تنازليا مع 
        sum = i + Recursion(n-1);
        return sum;
    }
}