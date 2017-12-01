/*Write a function named sumDigits which takes a number as 
input and returns the sum of the absolute value of each 
of the number's decimal digits.*/

public class Kata
{
  public static int SumDigits(int number)
  {
    number = System.Math.Abs(number);
    var sum = 0;
    while (number != 0) {
      sum += number % 10;
      number /= 10;
    }
    return sum;
  }
}