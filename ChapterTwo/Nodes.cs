using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Node
    {
      //Val = Value
        public int Val { get; set; }
          public Node Next;
            public Node(int val)
            {
                Val = val;
            //pointer
            Next = null;
            }
    }