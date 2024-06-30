using System;

// Implementation of a Stack data structure
public class Stack
{
    private int[] items; 
    private int top;   

    public Stack(int size)
    {
        items = new int[size]; 
        top = -1;              
    }
    // create some helper function
    
    public bool IsEmpty()
    {
        return top == -1; 
    }

    public bool IsFull()
    {
        return top == items.Length - 1; 
    }
    public void Push(int item)
    {
        if (IsFull())
        {
            Console.WriteLine("Stack Full!"); 
            return;
        }

        items[++top] = item; 
    }

    public int Pop()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Stack underflow"); 
            return -1;
        }

        return items[top--]; 
    }

    public int Top()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Stack is empty"); 
            return -1;
        }

        return items[top]; 
    }

    public static int Size(Stack stack)
    {
        return stack.top + 1; }
    //Maximam function 
    public static int Max(Stack stack)
    {
        if (stack.IsEmpty())
        {
            Console.WriteLine("Stack is empty"); 
            return -1;
        }

        int max = stack.Top();

        for (int i = stack.top; i >= 0; i--)
        {
            if (stack.items[i] > max)
            {
                max = stack.items[i]; // Update max 
            }
        }

        return max;}
    public static void Display(Stack stack)
    {
        if (stack.IsEmpty())
        {
            Console.WriteLine("Stack is empty");
            return;
        }

        Console.WriteLine("Stack elements");
        for (int i = stack.top; i >= 0; i--)
        {
            Console.Write(stack.items[i] + " "); 
        }
    }
    
}

