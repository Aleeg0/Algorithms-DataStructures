namespace Algorithm_DataStructures.Algorithms.Array;

public class ProductOfArrayExceptSelfTask
{
    public int[] ProductExceptSelf(int[] nums)
    {
        int[] answer = new int[nums.Length];
        answer[0] = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            answer[i] = answer[i - 1] * nums[i - 1];
        }

        int right = 1;
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            answer[i] *= right;
            right *= nums[i];
        }

        return answer;
    }
}