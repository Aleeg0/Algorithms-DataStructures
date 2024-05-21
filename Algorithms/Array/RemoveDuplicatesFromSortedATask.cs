namespace Algorithm_DataStructures.Algorithms.Array;

public class RemoveDuplicatesFromSortedATask
{
    public int RemoveDuplicates(int[] nums)
    {
        int leftIndex = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i - 1] != nums[i])
                nums[leftIndex++] = nums[i];
        }

        return leftIndex;
    }
}