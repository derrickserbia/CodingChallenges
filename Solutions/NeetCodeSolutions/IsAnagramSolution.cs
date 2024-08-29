public class IsAnagramSolution : INeetCodeSolutions
{
    public void SolveProblem()
    {
        var s = "racecar";
        var t = "carrace";

        Console.WriteLine(IsAnagram(s, t));
    }

    private bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }

        var abc = "abcdefghijklmnopqrstuvwxyz";
        var hashset = new Dictionary<char, int>();
        foreach (var c in abc)
        {
            hashset.Add(c, 0);
        }

        for (int i = 0; i < s.Length; i++)
        {
            hashset[s[i]]++;
            hashset[t[i]]--;
        }

        foreach (var key in hashset.Keys)
        {
            if (hashset[key] != 0)
            {
                return false;
            }
        }

        return true;
    }
}