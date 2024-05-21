namespace Algorithm_DataStructures.Algorithms.Array;

public class JumpGameTask
{
    public bool CanJump(int[] nums)
    {
        int goal = nums.Length - 1;
        for (int i = nums.Length - 2; i > -1; i--)
        {
            if (nums[i] + i >= goal)
                goal = i;
        }

        return goal == 0;
    }
}