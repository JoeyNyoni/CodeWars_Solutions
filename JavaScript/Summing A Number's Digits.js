/*Write a function named sumDigits which takes a number as input 
and returns the sum of the absolute value of each of the number's 
decimal digits.*/

function sumDigits(number) {
  number = Math.abs(number);
  
  var sum = 0;
  
  while(number != 0) {
    sum += number % 10;
    number = (number / 10 | 0);
  }
  return sum;
}