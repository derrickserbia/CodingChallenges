using LeetCode.Solutions;

class TwoSumSolution : ILeetCodeSolution
{
    public void SolveProblem()
    {
        int[] nums = [2, 7, 11, 15];
        int target = 9;

        int[] result = TwoSum(nums, target);
        Console.WriteLine("TwoSum Solution:");
        Console.WriteLine($"[{result[0]}, {result[1]}]");

        nums = [3, 2, 4];
        target = 6;

        result = TwoSum(nums, target);
        Console.WriteLine("TwoSum Solution:");
        Console.WriteLine($"[{result[0]}, {result[1]}]");
    }

    private int[] TwoSum(int[] nums, int target)
    {
        var numToIndex = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            var num = nums[i];
            var complement = target - num;
            if (numToIndex.ContainsKey(complement))
            {
                return new int[] { numToIndex[complement], i };
            }

            if (!numToIndex.ContainsKey(num))
            {
                numToIndex.Add(num, i);
            }
        }
        return [-1, -1];
    }
}