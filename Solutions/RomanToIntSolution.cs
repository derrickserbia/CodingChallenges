using CodingChallenges.Solutions;

class RomanToIntSolution : ILeetCodeSolution
{
    public void SolveProblem()
    {
        var s = "III";
        Console.WriteLine(RomanToInt(s).ToString());

        s = "LVIII";
        Console.WriteLine(RomanToInt(s).ToString());

        s = "MCMXCIV";
        Console.WriteLine(RomanToInt(s).ToString());
    }

    private int RomanToInt(string s)
    {
        var symbolValues = new Dictionary<char, int>()
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };
        var sum = 0;
        var previousValue = 0;

        foreach (char c in s)
        {
            var currentValue = symbolValues[c];

            if (previousValue < currentValue)
            {
                sum += currentValue - previousValue * 2;
            }
            else
            {
                sum += currentValue;
            }
            previousValue = currentValue;
        }

        return sum;
    }
}