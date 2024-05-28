namespace Algorithm_DataStructures.Algorithms.BitManipulation;

public class SingleNumber2Task
{
    public int SingleNumber(int[] nums)
    {
        int answer = 0;
        int curCoef = 1;
        bool isEnd;
        for (int j = 0; j < 32; j++)
        {
            isEnd = true;
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                count += nums[i] & 1;
                nums[i] >>= 1;
                if (isEnd && nums[i] != 0)
                    isEnd = false;
            }

            if (count % 3 != 0)
                answer += curCoef;
            if (isEnd)
                break;
            curCoef <<= 1;
        }

        return answer;
    }
}