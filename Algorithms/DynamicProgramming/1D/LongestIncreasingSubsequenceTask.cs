namespace Algorithm_DataStructures.Algorithms.DynamicProgramming._1D;

public class LongestIncreasingSubsequenceTask
{
    public int LengthOfLIS(int[] nums)
    {
        int[] best = new int[nums.Length];
        Array.Fill(best, 1);
        int max = 1;
        for (int i = nums.Length - 2; i >= 0; i--)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] < nums[j])
                    best[i] = int.Max(best[i], best[j] + 1);
                if (best[i] > max)
                    max = best[i];
            }
        }

        return max;
    }
}