using CodingChallenges.Solutions.Interfaces;

class KidsWithCandiesSolution : ILeetCodeSolution
{
    public void SolveProblem()
    {
        var candies = new[] { 2, 3, 5, 1, 3 };
        var extraCandies = 3;

        var result = KidsWithCandies(candies, extraCandies);

        foreach (var r in result)
        {
            System.Console.WriteLine(r);
        }
    }

    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        var max = candies.Max();
        var output = new List<bool>();
        foreach (var kid in candies)
        {
            output.Add(kid + extraCandies >= max);
        }
        return output;
    }
}