namespace LeetCode;

class Program
{
    static void Main(string[] args)
    {
        var factory = new LeetCodeSolutionFactory();

        var problemSolver = factory.CreateSolution(410);
        problemSolver.SolveProblem();

    }
}