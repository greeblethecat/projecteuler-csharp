using System;
using System.Collections.Generic;

public class Solution0001 : Solution {
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

public class Solution0002 : Solution {
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

public class Solution0003 : Solution {
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

public class Solution0004 : Solution {
  public override string run() {
    return base.run();
  }
}