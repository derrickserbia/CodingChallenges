using System.Globalization;
using LeetCode.Solutions;

class RemoveElementSolution : ILeetCodeSolution
{
    public void SolveProblem()
    {
        var nums = new int[] { 3, 2, 2, 3 };
        var result = RemoveElement(nums, 3);
        Console.WriteLine("result={0}", result);
    }

    private int RemoveElement(int[] nums, int val)
    {
        var n = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                nums[n++] = nums[i];
            }
        }
        return n;
    }
}