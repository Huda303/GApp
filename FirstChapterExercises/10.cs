class Exe10{
    int sumDigits(int n) { 
        // O (Log n) we are passing multiple steps in each opration and its decrise
    int sum = 0; //1
    while (n > 0) {// log n
        sum += n % 10; 
        n /= 10; 
    } 
    return sum; //1
} 

}