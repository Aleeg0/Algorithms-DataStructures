namespace Algorithm_DataStructures.Algorithms.HashMap;

public class ContainsDuplicateIITask
{
    public bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        Dictionary<int, int> dictionary = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (dictionary.TryGetValue(nums[i], out var value))
            {
                if (i - value <= k)
                    return true;
                dictionary.Remove(nums[i]);
            }

            dictionary.Add(nums[i], i);
        }

        return false;
    }
}