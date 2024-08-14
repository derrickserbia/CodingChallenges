using CodingChallenges.Factories;
using CodingChallenges.Solutions.Interfaces;

namespace CodingChallenges;

public class LeetCodeSolutionFactory : ICodingChallengeSolutionFactory
{
    private readonly Dictionary<int, Func<ILeetCodeSolution>> _solutions = new()
    {
        {1, () => new TwoSumSolution() },
        {2, () => new AddTwoNumbersSolution()},
        {3, () => new LengthOfLongestSubstringSolution()},
        {9, () => new IsPalindromeSolution()},
        {13, () => new RomanToIntSolution()},
        {14, () => new LongestCommonPrefixSolution()},
        {20, () => new ValidParenthesesSolution()},
        {21, () => new MergeTwoSortedListsSolution()},
        {26, () => new RemoveDuplicateFromSortedArraySolution()},
        {27, () => new RemoveElementSolution()},
        {28, () => new StrStrSolution()},
        {35, () => new SearchInsertSolution()},
        {410 , () => new WeeklyContest410Solution()}
    };
    public ICodingChallengeSolution CreateSolution(int problemNumber)
    {
        return _solutions.TryGetValue(problemNumber, out var factory)
        ? factory()
        : throw new ArgumentException("Invalid problem number");
    }
}