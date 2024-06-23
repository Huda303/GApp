// using System.Collections.Generic;
// using System.Linq;
// using System.Security.Cryptography.X509Certificates;
// using System.Text;
// using System.Threading.Tasks;
// using Microsoft.VisualBasic;

// namespace Grokking_Algorithm.Chapter_2
// {
//     public class LinkedList
//     {
//         private Node head;
//         public LinkedList()
//         {
//             head = null;
//         }
//         //adding data to the end of the list
//         public void AddBack(int data)
//         {
//             var newnode = new Node(data);
//             if (head == null)
//                 head = newnode;
//             else  
//             {
//                 // the same of add in back
//                 var temp = head;
//                 while (temp.Next != null)
//                 {
//                     temp = temp.Next;
//                 }
//                 temp.Next = newnode;
//             }
//         }

//         public void Display()
//         {

//             var temp = head;
//                 int counter = 0;
//             while (temp != null)
//             {
                   
//                 Console.Write(temp.Val+ " ");
//                 temp = temp.Next;
//             }
//             Console.WriteLine();
//         }
//        // singly linked list in reverse order.
//         public void Revers(Node node){
//             if (node == null)
//             {
//                 return;
//             }
//              Revers(node.Next);
//              Console.Write(node.Val + " ");
//         }
//         public void DisplayReverse()
//         {
//             Revers(head);
//         }
//         //Node counter
//         public int count()
//              {
//                 var temp = head;
//                 int counter = 0;
//                 while (temp != null)
//                 {
//                     counter++;
//                    // Console.Write(temp.Val + " ");
//                     temp = temp.Next;
//                 }
//                 return counter;
//             }
//         //Add at any pos
//         public void AddAtAnyPos(int position,int data)
//         {
//             int counter = count();
//             if(counter < position)
//             {
//                 Console.WriteLine("out of scope");
//                 return;
//             }
//              counter = 1;
//             var prev = head;
//             var next = head;
//              Node newnode=new Node(data);
//             //  1 2 3 4 
//             while (next != null&&counter<position)
//             {
//                 counter++;
//                 prev = next;
//                 next = next.Next;
//             }
//              if(next==prev)
//             {
//                 head = newnode;
//                 head.Next = prev;
//                 return;
//             }
//             prev.Next = newnode;
//             newnode.Next = next;
//         }
//         public void AddAtfront(int data)
//         {
//              Node newNode = new Node(data);
//                 newNode.Next = head;
//                 head = newNode;
//         }
//         public void AddAtEnd(int data)
//         {
//             Node newnode = new Node(data);
//             //اذا لم يكن هناك نود او كان المؤشر فارغ ينشأ نود جديد
//            if (head == null)
//            {
//              head = newnode;
//            } 
//            // غير ذلك نساوي النود الحالية بالمؤشر و طالما كانت النود التالية ليست فارغة فنؤشر على النود 
//            // التالي الى ان نجدالنود الاخيرة وبعدها ننشأ نود جديدة
//            else
//            {
//             Node current = head;
//                     while (current.Next != null)
//                     {
//                         current = current.Next;
//                     }
//                     current.Next = newnode;
                
//            }
//         }
//         //sraech for A node in list
//         public bool Find(int Data) {
//             var temp = head;
          
            
//             while(temp.Next.Next != null)
//             {
//                 if (temp.Val==Data)
//                     return true;
//                 temp = temp.Next;
//             }
//             temp.Next = null;
//             return false;
//         }
//         //find the first index
//         public int FindIndex(int item)
//         {
//             Node current = head;
//             int index = 0;

//             while (current != null)
//             {
//                 if (current.Val == item)
//                 {
//                     return index;
//                 }
//                  current = current.Next;
//                  index++;
//             }
//             // If element is not found, return -1
//             return -1;
//         } 
//         //Check if singly linked list is empty
//         public bool IsEmpty() 
//         {
//             bool result;
//             if (head == null)
//             {
//                result = true;
//             }     
//             else
//             {
//                 result = false;
//             }
//             return result;
//         }
//         // To empty a list
//          public void EmptyList()
//         {
//             head = null;
//         }

//     }
// }