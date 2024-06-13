class Exe9{
    public static int[] copyArray(int[] array) {
        // O(n^2)
    int[] copy = new int[0];//1
    foreach (var value in array)
    {
        copy = appendToNew(copy, value);//O(n)

    }
    return copy;//1
}
public static int[] appendToNew(int[] array, int value) {
    int[] bigger = new int[array.Length + 1];//1
    for (int I = 0; I < array. Length; I++) {// O(n)
        bigger[I] = array[I];
    }
    bigger[bigger.Length - 1] = value; //1
    return bigger;
}

}