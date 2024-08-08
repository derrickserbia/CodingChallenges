using LeetCode.Solutions;

namespace LeetCode.Factories;

public interface ILeetCodeSolutionFactory
{
    ILeetCodeSolution CreateSolution(int problemNumber);
}