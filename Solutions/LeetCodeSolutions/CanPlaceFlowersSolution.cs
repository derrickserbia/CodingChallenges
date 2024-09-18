using CodingChallenges.Solutions.Interfaces;

class CanPlaceFlowersSolution : ILeetCodeSolution
{
    public void SolveProblem()
    {
        var flowerbed = new int[] { 1, 0, 0, 0, 1, 0, 0 };
        System.Console.WriteLine(CanPlaceFlowers(flowerbed, 2));
    }

    private bool CanPlaceFlowers(int[] flowerbed, int n)
    {
        if (flowerbed.Length == 1 && flowerbed[0] == 0 && n == 1)
            return true;

        int count = n;
        int i = 0;

        while (i + 1 < flowerbed.Length && count > 0)
        {
            if (flowerbed[i] == 0 && flowerbed[i + 1] == 0)
            {
                count--;
            }
            i += 2;
        }

        return count == 0;
    }
}