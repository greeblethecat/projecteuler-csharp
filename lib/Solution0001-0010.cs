using System;

public class Solution0001 : Solution
{
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

public class Solution0002 : Solution
{
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