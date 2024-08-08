using LeetCode.Solutions;
using Microsoft.VisualBasic;

class ValidParenthesesSolution : ILeetCodeSolution
{
    public void SolveProblem()
    {
        var s = "()";
        Console.WriteLine(IsValid(s));

        s = "(()[]{})";
        Console.WriteLine(IsValid(s));
    }

    private bool IsValid(string s)
    {
        var stack = new Stack<char>();
        foreach (var c in s)
        {
            if (IsOpening(c))
            {
                stack.Push(c);
            }
            else if (IsClosing(c))
            {
                stack.TryPeek(out char temp);
                if (IsValidPair(temp, c))
                {
                    stack.Pop();
                }
                else
                {
                    return false;
                }
            }
        }

        return stack.Count == 0;
    }

    private bool IsValidPair(char opening, char closing)
    {
        switch (opening)
        {
            case '(':
                return closing == ')';
            case '{':
                return closing == '}';
            case '[':
                return closing == ']';
            default:
                return false;
        }
    }

    private bool IsOpening(char a)
    {
        return a == '(' || a == '{' || a == '[';
    }

    private bool IsClosing(char a)
    {
        return a == ')' || a == '}' || a == ']';
    }
}