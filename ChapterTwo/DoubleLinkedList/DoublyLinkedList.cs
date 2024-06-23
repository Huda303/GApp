using System.Security.Cryptography.X509Certificates;

public class DuobleLinkedList
    {
        private Node head;
        private Node tail;
        
        public void DoubleLinkedList()
        {
            head = null;
            tail = null;
        }
        public void AddBack(int data)
    {
        Node newNode = new Node(data);
        if (head == null)
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            tail.next = newNode;
            newNode.Prev = tail;
            tail = newNode;
        }
    }

    public void AddFront(int data)
        {
            Node newNode = new Node(data);
        if (head == null)
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
           newNode.next = head;
           head.Prev = newNode;
           head = newNode;
        } 
        }
        public void Display()
    {
        Node current = head;
        while (current != null)
        {
            Console.Write(current.Data);
            current = current.next;
        }
        Console.WriteLine();
    }
     public void ReverseOrder()
    {
        Node current = tail;
        while (current != null)
        {
            Console.Write(current.Data);
            current = current.Prev;
        }
        Console.WriteLine();
    }

    //ADD At any position
    //اذا كان الموقع المراد هو اول موقع فتتم الاضافة مثل دالة addFront
     public void AddPosition(int position,int data)
        {
            Node NewNode = new Node(data);
            if(position==0)
            {
                head.Prev = NewNode;
                NewNode.next=head;
                head= NewNode;
                return; 
            }
            int counter = 0;
            Node current=head;
            Node pr = head;
            while(current!=null)
            {
                // اذا كان الموقع المراد نفس عدد العداد نلوب عليه الا ان نصل موقعه ونضيف
                if(counter == position)
                {
                    NewNode.next = current;
                    NewNode.Prev = pr;
                    pr.next = NewNode;
                    current.Prev = NewNode;
                    return;
                }
                counter++;
                pr=current;
                current= current.next;
            }
                Console.WriteLine("choes another position");
        }

    }