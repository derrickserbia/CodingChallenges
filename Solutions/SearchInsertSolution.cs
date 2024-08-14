using System.Formats.Asn1;
using CodingChallenges.Solutions;

class SearchInsertSolution : ILeetCodeSolution
{
    public void SolveProblem()
    {
        var nums = new int[] { 0 };
        nums = [1, 3, 5, 6];
        var sol = SearchInsert(nums, 0);
        Console.WriteLine(sol.ToString());
    }

    private int SearchInsert(int[] nums, int target)
    {
        int i = 0, j = nums.Length - 1, m;

        while (i <= j)
        {
            if (i == j)
            {
                if (nums[i] == target)
                    return i;
                else if (target < nums[i])
                    return i;
                else
                    return i + 1;
            }

            m = (i + j) / 2;
            if (nums[m] == target)
            {
                return m;
            }

            if (nums[m] < target) //
            {
                i = m + 1;
            }
            else
            {
                j = m - 1;
            }
        }

        return i;
    }
}