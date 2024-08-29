namespace CodingChallenges;

class Program
{
    static void Main(string[] args)
    {
        var factory = new SolutionFactory();

        var problemSolver = factory.CreateSolution(1, "neetcode");
        problemSolver.SolveProblem();

    }
}