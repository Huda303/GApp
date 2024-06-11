class Exercises2{
public static int power(int a, int b) {
    // O(n) where n is b
    // في اسوأ الحالات نأخذ طول b وهي الحالة الوحيدة
    if (b < 0) return a;
    if (b == 0) return 1;
    int sum = a;
    for (int I = 0; I < b - 1; I++) {
        sum *= a;
    }
    return sum;
}

}
