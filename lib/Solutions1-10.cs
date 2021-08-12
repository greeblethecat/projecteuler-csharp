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
