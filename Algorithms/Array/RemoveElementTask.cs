namespace Algorithm_DataStructures.Algorithms.Array;

public class RemoveElementTask
{
    public int RemoveElement(int[] nums, int val)
    {
        int left = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                nums[left++] = nums[i];
            }
        }

        return left;
    }
}