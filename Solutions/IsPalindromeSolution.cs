using LeetCode.Solutions;

class IsPalindromeSolution : ILeetCodeSolution
{
    public void SolveProblem()
    {
        var input = 121;
        Console.WriteLine("IsPalindrome solution:");
        Console.WriteLine(IsPalindrome(input));
    }

    private bool IsPalindrome(int x)
    {
        if (x < 0)
            return false;

        int reverseX = 0;
        var xCopy = x;

        while (xCopy > 0)
        {
            reverseX = (reverseX * 10) + (xCopy % 10);
            xCopy /= 10;
        }
        return x == reverseX;
    }
}