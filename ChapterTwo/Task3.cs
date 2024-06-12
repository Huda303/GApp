class Task3 {
    public static void LinkedList() 
    {
        LinkedList<string> Names = new LinkedList<string>();
         Names.AddFirst("Huda");
         Names.AddFirst("Eman");
        foreach (string item in Names)
        {
            //Console.WriteLine(item);
        }
        //To count the nodes
        Console.WriteLine(Names.Count());
    }
}