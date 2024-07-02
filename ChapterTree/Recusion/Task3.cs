using System;
class Program3 {
     
    public int Fibonacci(int n)
    {
        for (int i = 0; i < 9; i++)
        {
           if(n == 0)
                return 0;
            else if(n == 1)
                return 1;
            else
                return Fibonacci(n-1) + Fibonacci(n-2);   
        }
        return 0;
    }
}