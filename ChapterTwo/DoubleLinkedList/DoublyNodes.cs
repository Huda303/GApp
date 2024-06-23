public class Node
{
    public int Data { get; set; }
    public Node next { get; set; }
    public Node Prev { get; set; }

    public Node(int data)
    {
        Data = data;
        next = null;
        Prev = null;
    }
}
