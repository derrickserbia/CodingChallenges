using System.Security.Cryptography.X509Certificates;
using CodingChallenges.Solutions;

class LongestCommonPrefixSolution : ILeetCodeSolution
{
    public void SolveProblem()
    {
        var strs = new string[] { "flower", "flow", "flight", "" };
        Console.Write(LongestCommonPrefix(strs));
    }

    private string LongestCommonPrefix(string[] strs)
    {
        if (strs.Length == 1)
            return strs[0];

        var longestCommonPrefix = "";
        for (int i = 0; i < strs[0].Length; i++)
        {
            var targetChar = strs[0][i];
            foreach (var str in strs)
            {
                try
                {
                    var c = str[i];
                    if (c != targetChar)
                    {
                        return longestCommonPrefix;
                    }
                }
                catch (Exception)
                {
                    return longestCommonPrefix;
                }
            }
            longestCommonPrefix += targetChar;

        }

        return longestCommonPrefix;
    }
}