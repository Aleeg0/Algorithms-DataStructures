namespace Algorithm_DataStructures.Algorithms.Array;

public class RotateArrayTask
{
    public void Rotate(int[] nums, int k)
    {
        if (nums.Length < k)
            k %= nums.Length;
        // first reverse  
        int size = nums.Length / 2;
        for (int i = 0; i < size; i++)
        {
            (nums[i], nums[nums.Length - i - 1]) = (nums[nums.Length - i - 1], nums[i]);
        }

        // second reverse
        size = (nums.Length + k) / 2;
        for (int i = k; i < size; i++)
        {
            (nums[i], nums[nums.Length - i - 1 + k]) = (nums[nums.Length - i - 1 + k], nums[i]);
        }

        // third reverse
        size = k / 2;
        for (int i = 0; i < size; i++)
        {
            (nums[i], nums[k - i - 1]) = (nums[k - i - 1], nums[i]);
        }
    }
}