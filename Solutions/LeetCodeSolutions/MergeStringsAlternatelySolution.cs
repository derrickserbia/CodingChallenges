using CodingChallenges.Solutions.Interfaces;

class MergeStringsAlternatelySolution : ILeetCodeSolution
{
    public void SolveProblem()
    {
        var word1 = "abc098767";
        var word2 = "pqr123";

        Console.WriteLine(MergeAlternately(word1, word2));
    }

    private string MergeAlternately(string word1, string word2)
    {
        var l1 = word1.Length;
        var l2 = word2.Length;

        int i = 0, j = 0;

        var merged = string.Empty;

        while (i < l1 && j < l2)
        {
            merged += $"{word1[i++]}{word2[j++]}";
        }
        if (i < l1)
        {
            merged += word1.Substring(i);
        }
        if (j < l2)
        {
            merged += word2.Substring(j);
        }

        return merged;
    }
}