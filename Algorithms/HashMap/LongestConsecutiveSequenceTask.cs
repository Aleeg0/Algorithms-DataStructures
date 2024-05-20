namespace Algorithm_DataStructures.Algorithms.HashMap;

public class LongestConsecutiveSequenceTask
{
    public int LongestConsecutive(int[] nums)
    {
        SortedSet<int> temp = new SortedSet<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            temp.Add(nums[i]);
        }

        int bestAnswer = 0;
        int curAnswer = 0;
        int prevNum = 0;
        foreach (var num in temp)
        {
            if (curAnswer != 0 && num - 1 != prevNum)
                curAnswer = 0;
            prevNum = num;
            curAnswer++;
            if (curAnswer > bestAnswer)
                bestAnswer = curAnswer;
        }

        return bestAnswer;
    }
}