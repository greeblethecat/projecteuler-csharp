public class Solution {
  virtual public string run() { return null; }
}

public static class Utils {
  public static bool isPalindrome(string s) {
    for (int i = 0; i < s.Length/2; i++) {
      if (s[i]!=s[s.Length-i-1]) {
        return false;
      }
    }
    return true;
  }

  public static bool isPrime(long n) {
    for (long i = 2; i <= n/2; i++) {
      if (n%i == 0) {
        return false;
      }
    }
    return true;
  }
}