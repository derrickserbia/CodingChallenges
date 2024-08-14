using CodingChallenges.Solutions.Interfaces;

namespace CodingChallenges.Factories;

public interface ICodingChallengeSolutionFactory
{
    ICodingChallengeSolution CreateSolution(int problemNumber);
}