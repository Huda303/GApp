class Task2 {
    public static void LinkedList() 
    {
        LinkedList<int> Nums = new LinkedList<int>();
        //adding items to the list
        for (int i = 0; i < 10; i++)
        {
            Nums.AddFirst(i);
        }
        //Displaying the list
        foreach (var item in Nums)
        {
                    Console.WriteLine(item);

        }
    }
}