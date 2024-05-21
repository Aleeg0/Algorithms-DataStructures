namespace Algorithm_DataStructures.Algorithms.Intervals;

public class MergeIntervalsTask
{
    public int[][] Merge(int[][] intervals)
    {
        if (intervals.Length == 1)
            return intervals;
        System.Array.Sort(intervals, MyComparer);
        List<int[]> answer = new List<int[]>();
        int j = 0;
        int cur = 0;
        int next = 1;
        while (cur < intervals.Length)
        {
            answer.Add(new int[2]);
            answer[j] = intervals[cur];
            while (next < intervals.Length && answer[j][1] >= intervals[next][0])
            {
                if (answer[j][1] < intervals[next][1])
                    answer[j][1] = intervals[next][1];
                next++;
            }

            cur = next++;
            j++;
        }

        return answer.ToArray();
    }

    private int MyComparer(int[] arr1, int[] arr2)
    {
        if (arr1[0] > arr2[0])
            return 1;
        if (arr1[0] < arr2[0])
            return -1;
        return 0;
    }
}