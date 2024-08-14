namespace CodingChallenges;

class Program
{
    static void Main(string[] args)
    {
        var factory = new LeetCodeSolutionFactory();

        var problemSolver = factory.CreateSolution(1);
        problemSolver.SolveProblem();

    }
}