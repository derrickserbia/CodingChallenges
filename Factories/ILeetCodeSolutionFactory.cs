using CodingChallenges.Solutions;

namespace CodingChallenges.Factories;

public interface ILeetCodeSolutionFactory
{
    ILeetCodeSolution CreateSolution(int problemNumber);
}