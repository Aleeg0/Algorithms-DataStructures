namespace Algorithm_DataStructures.Algorithms.Array;

public class RemoveDuplicatesFromSortedA2Task
{
    public int RemoveDuplicates(int[] nums)
    {
        int left = 1;
        for (int right = 1; right < nums.Length; right++)
        {
            if (left == 1 || nums[right] != nums[left - 2])
                nums[left++] = nums[right];
        }

        return left;
    }
}