namespace Algorithm_DataStructures.Algorithms.SlidingWindow;

public class MinimumSizeSubarraySumTask
{
    public int MinSubArrayLen(int target, int[] nums)
    {
        int curSum = 0;
        int left = 0;
        int right = 0;
        int minCount = 0;
        while (right < nums.Length)
        {
            curSum += nums[right];
            if (curSum >= target)
            {
                while (curSum - nums[left] >= target)
                    curSum -= nums[left++];
                int temp = right - left + 1;
                if (minCount == 0 || minCount > temp)
                    minCount = temp;
            }

            right++;
        }

        return minCount;
    }
}