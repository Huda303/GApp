class Task1 {
    public static void LinkedList() 
    {
        LinkedList<String> Names = new LinkedList<string>();
        //adding items to the list by using functions 
        Names.AddFirst("Huda");
        Names.AddFirst("Eman");
        foreach (string item in Names)
        {
            Console.WriteLine(item);
        }
    }
}