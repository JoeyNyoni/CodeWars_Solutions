/*
You are given an odd-length array of integers, in which all of them are the same, 
except for one single number.

Complete the method which accepts such an array, and returns that single different number.

The input array will always be valid! (odd-length >= 3)
*/

using System.Collections.Generic;
using System.Linq;

class Solution 
{
  public static int Stray(int[] numbers)
  {
    var val = 0;
    int[] unique = numbers.Distinct().ToArray();
    Dictionary<int, int> intCount = new Dictionary<int, int>();
    for (var i = 0; i < unique.Length; i++)
    {
      var total = 0;
      for (var j = 0; j < numbers.Length; j++)
      {
        if (unique[i] == numbers[j])
          total++;  
      }
      intCount.Add(unique[i], total);
    }
    foreach (var record in intCount){  
      if (record.Value == 1)
        val = record.Key;
    }
    return val;
  }
}
