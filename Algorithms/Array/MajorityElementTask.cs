namespace Algorithm_DataStructures.Algorithms.Array;

public class MajorityElementTask
{
    public int MajorityElement(int[] nums)
    {

        int majority = nums[0];
        int count = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] == majority)
                count++;
            else
            {
                count--;
                if (count == 0)
                {
                    majority = nums[i];
                    count = 1;
                }
            }
        }

        return majority;
    }
}