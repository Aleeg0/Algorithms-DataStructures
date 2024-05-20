namespace Algorithm_DataStructures.Algorithms.Intervals;

public class SummaryRangesTask
{
    public IList<string> SummaryRanges(int[] nums)
    {
        if (nums.Length == 0)
            return new List<string>();
        int start = 0;
        string curString = nums[0].ToString();
        List<string> answer = new List<string>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (i - start != nums[i] - nums[start])
            {
                answer.Add(start == i - 1 ? curString : curString + "->" + nums[i - 1]);
                curString = nums[i].ToString();
                start = i;
            }

            if (i == nums.Length - 1)
            {
                answer.Add((start == i) ? curString : curString + "->" + nums[i]);
            }
        }

        return answer;
    }
}