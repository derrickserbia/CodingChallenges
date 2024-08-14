using CodingChallenges.Solutions;

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

    }

    private int LengthOfLongestSubstring(string s)
    {
        var maxLenght = 0;
        if (s.Length == 0)
            return maxLenght;

        maxLenght++; // by this point maxLength will be at least 1
        var leftIndex = 0;
        var rightIndex = leftIndex + 1; // what if string is a?

        var set = new HashSet<char>() { s[leftIndex] }; //initialize with the first character

        // stop once the right index reaches the end of the string
        while (rightIndex < s.Length)
        {
            // check if rightIndex character is in the set
            // if it is in the set, we have reached the end of the substring
            // if not, add the char to the set and keep increasing the right index
            if (set.Contains(s[leftIndex]))
            {
                maxLenght = ((rightIndex - leftIndex) > maxLenght) ? (rightIndex - leftIndex) : maxLenght;
                set.Remove(s[leftIndex++]);
                rightIndex++;
            }
            else
            {
                set.Add(s[rightIndex++]);
                maxLenght++;
            }
        }

        return maxLenght;
    }
}