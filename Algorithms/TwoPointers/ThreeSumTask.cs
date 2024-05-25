namespace Algorithm_DataStructures.Algorithms.TwoPointers;

public class ThreeSumTask
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        IList<IList<int>> answer = new List<IList<int>>();
        int left = 0;
        int right = 0;
        System.Array.Sort(nums);
        for (int i = 0; i < nums.Length - 2; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1])
                continue;
            left = i + 1;
            right = nums.Length - 1;
            while (left < right)
            {
                int temp = nums[i] + nums[left] + nums[right];
                if (temp == 0)
                {
                    answer.Add(new List<int>() { nums[i], nums[left], nums[right] });
                    left++;
                    while (left < right && nums[left - 1] == nums[left])
                        left++;
                }
                else if (temp > 0)
                    right--;
                else
                    left++;
            }
        }

        return answer;
    }
}