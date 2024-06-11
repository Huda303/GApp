class Exe4{
public static int div(int a, int b) {
    // The max is in the loop O(n)
    int count = a; //1
    int sum = b;//1
    while (sum <= a) //n
    {
        sum += b;
        count++;
    }
    return count;
}

}
