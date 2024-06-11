class Exercises{
  public static int StepCounter(){
    //The goal is to calculate the steps of the binary search algorithm
    int steps = 16384;
    //Calculate the maximum steps in our algorithm using the equation
    //I used (int) cuz Log2 data type is double and Ceiling is int so we can't convert without it
    int MaxNumberOfSteps = (int)Math.Ceiling(Math.Log2(steps));
    //In every time it divide the result over 2 until it reachs the result (number 1)
    return MaxNumberOfSteps;
    //If you double the size of the steps it's gonna increase the result by 1 2^7 = 128 & 2^8 = 256
  }


}