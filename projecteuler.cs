using System;

public class ProjectEuler {
  public static void Main(string[] args) {
    string solutionId = args[0];
    var type = Type.GetType("Solution" + solutionId);
    var solution = (Solution)Activator.CreateInstance(type);
    var answer = solution.run();
    Console.WriteLine(answer);
  }
}