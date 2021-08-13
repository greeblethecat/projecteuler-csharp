using System;
using System.Collections.Generic;

public class Solution1 : Solution {
  override public string run() {
    int answer = 0;
    for (int i = 0; i < 1000; i++) {
      if (i % 3 == 0 || i % 5 == 0) {
        answer += i;
      }
    }
    return answer.ToString();
  }
}

public class Solution2 : Solution {
  public override string run() {
    int answer = 2;
    int f_2 = 1, f_1 = 2, f0 = 3;
    while (f0 < 4000000) {
      if (f0 % 2 == 0) {
        answer += f0;
      }
      int f_3 = f_2;
      f_2 = f_1;
      f_1 = f0;
      f0 = f_2 + f_1;
    }
    return answer.ToString();
  }
}

public class Solution3 : Solution {
  public override string run() {
    long answer = 0;
    long num = 600851475143;
    long curNum = num;
    while(curNum > 1) {
      for (int i = 2; i <= curNum; i++) {
        if (curNum%i == 0) {
          if (i > answer) {
            answer = i;
          }
          curNum /= i;
        }
      }
    }

    return answer.ToString();
  }
}

public class Solution4 : Solution {
  public override string run() {
    int answer = 0;
    for (int a = 100; a <= 999; a++) {
      for (int b = a; b <= 999; b++) {
        var p = a * b;
        if (Utils.isPalindrome(p.ToString())) {
          if (p > answer) { answer = p; }
        }
      }
    }
    return answer.ToString();
  }
}

public class Solution5 : Solution {
  public override string run() {
    int answer = 0;
    int limit = 20;
    int current = 2*3*5*7*11*13*17*19;
    while(answer == 0) {
      for (int i = 2; i <= limit; i++) {
        if (current%i != 0) {
          break;
        } else if (i == limit) {
          answer = current;
          break;
        }
      }
      current += 1;
    }
    return answer.ToString();
  }
}

public class Solution6 : Solution {
  public override string run() {
    long answer = 0;
    long limit = 100;
    long sumOfSquares = 0, squareOfSum = 0;
    for (int i = 1; i <= limit; i++) {
      sumOfSquares += i*i;
      squareOfSum += i;
    }
    squareOfSum *= squareOfSum;
    answer = squareOfSum - sumOfSquares;
    return answer.ToString();
  }
}

public class Solution7 : Solution {
  public override string run() {
    int answer = 0;
    int numPrimes = 0;
    int limit = 10001;
    int counter = 1;
    while (numPrimes <= limit) {
      if (Utils.isPrime(counter)) {
        answer = counter;
        numPrimes++;
      }
      counter++;
    }
    return answer.ToString();
  }
}

public class Solution8 : Solution {
  public override string run() {
    string s = "7316717653133062491922511967442657474235534919493496983520312774506326239578318016984801869478851843858615607891129494954595017379583319528532088055111254069874715852386305071569329096329522744304355766896648950445244523161731856403098711121722383113622298934233803081353362766142828064444866452387493035890729629049156044077239071381051585930796086670172427121883998797908792274921901699720888093776657273330010533678812202354218097512545405947522435258490771167055601360483958644670632441572215539753697817977846174064955149290862569321978468622482839722413756570560574902614079729686524145351004748216637048440319989000889524345065854122758866688116427171479924442928230863465674813919123162824586178664583591245665294765456828489128831426076900422421902267105562632111110937054421750694165896040807198403850962455444362981230987879927244284909188845801561660979191338754992005240636899125607176060588611646710940507754100225698315520005593572972571636269561882670428252483600823257530420752963450";
    char[] n = new char[s.Length];
    for (int i = 0; i < s.Length; i++) {
      n[i] = ((char)char.GetNumericValue(s[i]));
    }
    int numAdjacent = 13;
    long answer = 0;
    for (int i = 0; i < n.Length - numAdjacent; i++) {
      long product = 1;
      for (int p = 0; p < numAdjacent; p++) {
        product *= n[i+p];
        if (product == 0) {
          break;
        }
      }
      if (product > answer) {
        answer = product;
      }
    }
    return answer.ToString();
  }
}

public class Solution9 : Solution {
  public override string run() {
    for (double a = 1; a < 1000; a++) {
      for (double b = 1; b < (1000-a); b++) {
        double c = Math.Sqrt(a*a + b*b);
        if (a + b + c == 1000) {
          return (a*b*c).ToString();
        }
      }
    }
    return "poop";
  }
}
 