class Exe3{
    public static int mod(int a, int b) {
        // O(1) the muximum is 1
    if (b <=a) return -1; //1
    int div = a / b; //1
    return a - div * b; //1
}
}