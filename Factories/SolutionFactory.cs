using CodingChallenges.Factories;
using CodingChallenges.Solutions.Interfaces;

namespace CodingChallenges;

public class SolutionFactory : ISolutionFactory
{
    private readonly Dictionary<int, Func<ICodingChallengeSolution>> _leetCodeSolutions = new()
    {
        {1, () => new TwoSumSolution() },
        {2, () => new AddTwoNumbersSolution()},
        {3, () => new LengthOfLongestSubstringSolution()},
        {5, () => new LongestPalindromicSubstringSolution()},
        {9, () => new IsPalindromeSolution()},
        {13, () => new RomanToIntSolution()},
        {14, () => new LongestCommonPrefixSolution()},
        {20, () => new ValidParenthesesSolution()},
        {21, () => new MergeTwoSortedListsSolution()},
        {26, () => new RemoveDuplicateFromSortedArraySolution()},
        {27, () => new RemoveElementSolution()},
        {28, () => new StrStrSolution()},
        {35, () => new SearchInsertSolution()},
        {410 , () => new WeeklyContest410Solution()},
        {1431, () => new KidsWithCandiesSolution()},
        {1768, () => new MergeStringsAlternatelySolution()}
    };

    private readonly Dictionary<int, Func<ICodingChallengeSolution>> _neetCodeSolutions = new()
    {
        {1, () => new IsAnagramSolution() },
    };
    public ICodingChallengeSolution CreateSolution(int problemNumber, string type)
    {
        Func<ICodingChallengeSolution> factory;

        return type.ToLower() switch
        {
            "neetcode" => _neetCodeSolutions.TryGetValue(problemNumber, out factory)
                            ? factory()
                            : throw new ArgumentException("Invalid problem number"),
            "leetcode" => _leetCodeSolutions.TryGetValue(problemNumber, out factory)
                            ? factory()
                            : throw new ArgumentException("Invalid problem number"),
            _ => throw new ArgumentException("Invalid problem type"),
        };
    }
}