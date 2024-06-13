class Exe6{
    public static int sqrt(int n) {
        // steps = O (sqrt n)
    for (int guess = 1; guess * guess < n; guess++)//sqrt n
     {
        if (guess * guess == n) return guess;
    }
    return -1;
}

}