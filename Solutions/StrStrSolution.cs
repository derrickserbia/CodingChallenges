using LeetCode.Solutions;

class StrStrSolution : ILeetCodeSolution
{
    public void SolveProblem()
    {
        var sol = StrStr("mississippi", "issipi");
        Console.WriteLine(sol);
    }

    private int StrStr(string haystack, string needle)
    {
        var output = -1;
        if (needle.Length > haystack.Length || (needle.Length == haystack.Length && needle != haystack))
            return output;

        var cNeedle = needle[0];
        for (var h = 0; h < haystack.Length; h++)
        {
            if (cNeedle == haystack[h])
            {
                var found = true;
                for (var n = 0; n < needle.Length; n++)
                {
                    if (h + n >= haystack.Length || needle[n] != haystack[h + n])
                    {
                        found = false;
                        break;
                    }
                }
                if (found)
                    return h;
            }
        }

        return output;
    }
}