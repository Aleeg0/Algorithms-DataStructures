namespace Algorithm_DataStructures.Algorithms.DynamicProgramming._1D;

public class HouseRobberTask
{
    public int Rob(int[] nums)
    {
        if (nums.Length == 1)
            return nums[0];
        if (nums.Length == 2)
            return System.Math.Max(nums[0], nums[1]);
        int[] temp = new int[nums.Length];
        temp[0] = nums[0];
        temp[1] = System.Math.Max(nums[0], nums[1]);
        for (int i = 2; i < nums.Length; i++)
        {
            temp[i] = (temp[i - 2] + nums[i] > temp[i - 1]) ? temp[i - 2] + nums[i] : temp[i - 1];
        }

        return temp[nums.Length - 1];
    }
}