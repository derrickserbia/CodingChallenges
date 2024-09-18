using CodingChallenges.Solutions.Interfaces;

class LongestPalindromicSubstringSolution : ILeetCodeSolution
{
    public void SolveProblem()
    {
        var s = "babad";
        Console.WriteLine(LongestPalindrome(s));

        s = "cbbd";
        Console.WriteLine(LongestPalindrome(s));

    }

    private string LongestPalindrome(string s)
    {
        int i, j;
        var longestPalindrome = string.Empty;

        if (s.Length % 2 == 0)
        {
            i = (s.Length / 2) - 1;
            j = s.Length / 2;
        }
        else
        {
            i = j = s.Length / 2;
        }

        if (s[i] == s[j])
        {
            longestPalindrome = s.Substring(i, j - i + 1);
        }

        return longestPalindrome;
    }
}