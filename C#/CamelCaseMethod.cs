// Write simple .camelCase method (camel_case function in PHP, CamelCase in C# or camelCase in Java) 
// for strings. All words must have their first letter capitalized without spaces.

using System.Globalization;

namespace Kata
{
  public static class Problem
  {
    public static string CamelCase(this string str)  
    {  
      //your code here
      var cap = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str);
      return cap.Replace(" ", string.Empty);
    }
  }
}