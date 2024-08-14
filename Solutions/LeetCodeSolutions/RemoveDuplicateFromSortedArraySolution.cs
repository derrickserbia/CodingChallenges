using System.Collections;
using CodingChallenges.Solutions.Interfaces;

class RemoveDuplicateFromSortedArraySolution : ILeetCodeSolution
{
    public void SolveProblem()
    {
        var nums = new int[] { 1, 1, 2 };
        var output = RemoveDuplicates(nums);

        foreach (var item in nums)
        {
            Console.Write("{0} ", item);
        }
        Console.WriteLine();

        Console.WriteLine(output);
    }

    private int RemoveDuplicates(int[] nums)
    {
        var orderNumber = new Hashtable();
        var count = 0;

        var leftIndex = 0;
        var rightIndex = nums.Length - 1;

        for (int i = 0; i < nums.Length; i++)
        {
            var num = nums[i];
            if (orderNumber.ContainsValue(num))
            {
                orderNumber.Add(rightIndex--, num);
            }
            else
            {
                count++;
                orderNumber.Add(leftIndex++, num);
            }
        }

        foreach (DictionaryEntry entry in orderNumber)
        {
            nums[(int)entry.Key] = (int)entry.Value;
        }

        return count;
    }
}