namespace CodingChallenges;

class Program
{
    static void Main(string[] args)
    {
        var factory = new LeetCodeSolutionFactory();

        var problemSolver = factory.CreateSolution(35);
        problemSolver.SolveProblem();

    }
}