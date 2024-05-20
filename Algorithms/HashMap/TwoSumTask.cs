namespace Algorithm_DataStructures.Algorithms.HashMap;

public class TwoSumTask
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> dictionary = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int temp = target - nums[i];
            if (dictionary.TryGetValue(temp, out var value))
                return [value, i];
            dictionary.TryAdd(nums[i], i);
        }

        return [];
    }
}