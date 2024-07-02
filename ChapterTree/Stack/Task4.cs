 using System.Collections.Generic;
/*I'm using array to implement the stack 
- for the push function we have to check one condetion which is if the stack is full
- for the pop function we have to check one condetion which is if the stack is emptysame as well for the display*/
namespace StackImplementation{
    public class Stack1{
        private int top;
        private int max;
        private int [] Elements;
        public Stack1(int size){
            // top = -1 to make it point under or befor the stack
            this.top = -1;
            this.max = size;
            Elements = new int[size];
        }
        // begn of push
        public void Push(int element){
            if (top == max -1)
            {
                Console.WriteLine("The stack is full");
                return;
            }
            else
            {
               Elements[++top] = element;
            }
        }
        //end of push

        //begn of pop 
        public int Pop(){
            if (top == -1)
            {
                Console.WriteLine("The stack is empty");
                return -1;
            }
            else
            {
                Console.WriteLine("The stack has been poped");
                return Elements[top--];
            }
        }
        // end of pop

        //begn of display
        public void Display(){
            if (top == -1)
            {
                Console.WriteLine("The stack is empty");
                return;
            }
            else
            {
               for (int i = 0; i > top; i--)
               {
                Console.WriteLine(Elements[i]);
               }
            }
        }
        //end of display

    }
}