using CodingChallenges.Solutions.Interfaces;

namespace CodingChallenges.Factories;

public interface ISolutionFactory
{
    ICodingChallengeSolution CreateSolution(int problemNumber, string type);
}