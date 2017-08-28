using System;
using System.Linq;

namespace PalindromeApp.src 
{
  public static class PalindromeChecker
  {

    public static bool Check(string s)
    {
    s = s.ToLower();
    var a = String.Copy(s);
    var reversed = s.Reverse();
    s = reversed.ToString();
    return s.Equals(a);
    }
  }
}