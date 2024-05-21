namespace Algorithm_DataStructures.Algorithms.Array;

public class JumpGame2Task
{
    public int Jump(int[] nums)
    {
        int[] temp = new int[nums.Length];
        int inf = 10001;
        System.Array.Fill(temp, inf);
        temp[0] = 0;
        for (int i = 0; i < nums.Length - 1; i++)
        {
            int j = 1;
            while (i + j < nums.Length && j <= nums[i])
            {
                if (temp[i] + 1 < temp[i + j])
                    temp[i + j] = temp[i] + 1;
                j++;
            }
        }

        return temp[^1];
    }
}