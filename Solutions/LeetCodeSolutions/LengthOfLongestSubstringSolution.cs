using CodingChallenges.Solutions.Interfaces;

class LengthOfLongestSubstringSolution : ILeetCodeSolution
{
    public void SolveProblem()
    {
        var s = "";
        Console.WriteLine("string=[{0}]. LengthOfLongestSubstring=[{1}]", s, LengthOfLongestSubstring(s).ToString());

        s = "a";
        Console.WriteLine("string=[{0}]. LengthOfLongestSubstring=[{1}]", s, LengthOfLongestSubstring(s).ToString());

        s = "aa";
        Console.WriteLine("string=[{0}]. LengthOfLongestSubstring=[{1}]", s, LengthOfLongestSubstring(s).ToString());

        s = "aaa";
        Console.WriteLine("string=[{0}]. LengthOfLongestSubstring=[{1}]", s, LengthOfLongestSubstring(s).ToString());

        s = "aba";
        Console.WriteLine("string=[{0}]. LengthOfLongestSubstring=[{1}]", s, LengthOfLongestSubstring(s).ToString());

        s = "aabaab!bb";
        Console.WriteLine("string=[{0}]. LengthOfLongestSubstring=[{1}]", s, LengthOfLongestSubstring(s).ToString());

    }

    private int LengthOfLongestSubstring(string s)
    {
        int maxLength = 0;
        if (s.Length == 0) return maxLength;

        int i = 0, j = 1;

        var chars = new HashSet<char> { s[i] };
        maxLength = chars.Count;

        while (j < s.Length)
        {
            if (chars.Contains(s[j]))
            {
                if (s[i] != s[j])
                {
                    chars.Remove(s[i++]);
                }
                else
                {
                    i++;
                    j++;
                }
            }
            else
            {
                chars.Add(s[j++]);
                maxLength = chars.Count > maxLength ? chars.Count : maxLength;
            }
        }


        return maxLength;
    }
}