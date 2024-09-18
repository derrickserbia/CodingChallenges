namespace CodingChallenges;

class Program
{
    static void Main(string[] args)
    {
        var factory = new SolutionFactory();

        var type = args[0];
        var problemNumber = Convert.ToInt32(args[1]);

        var problemSolver = factory.CreateSolution(problemNumber, type);
        problemSolver.SolveProblem();

    }
}