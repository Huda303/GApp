class Exe5{
    public static int sqrt(int n) {
        // O(Log n) 
    return sqrt_helper(n, 1, n);
}
    public static int sqrt_helper(int n, int min, int max) {
    if (max < min) return -1;
    int guess = (min + max) / 2;
    if (guess * guess == n) {
        return guess;
    // loop
    } else if (guess *guess <n) {
        return sqrt_helper(n, guess + 1, max) ; 
    } else { 
        return sqrt_helper(n, min, guess - 1);
    }
}

}