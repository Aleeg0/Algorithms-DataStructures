namespace Algorithm_DataStructures.Algorithms.Intervals;

public class InsertIntervalTask
{
    public int[][] Insert(int[][] intervals, int[] newInterval)
    {
        List<int[]> newIntervals = new List<int[]>(intervals);
        newIntervals.Add(newInterval);
        newIntervals.Sort(MyComparer);
        List<int[]> answer = new List<int[]>();
        int j = 0;
        int cur = 0;
        int next = 1;
        while (cur < newIntervals.Count)
        {
            answer.Add(new int[2]);
            answer[j] = newIntervals[cur];
            while (next < newIntervals.Count && answer[j][1] >= newIntervals[next][0])
            {
                if (answer[j][1] < newIntervals[next][1])
                    answer[j][1] = newIntervals[next][1];
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