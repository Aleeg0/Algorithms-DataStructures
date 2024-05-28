namespace Algorithm_DataStructures.Algorithms.Intervals;

public class MinimumNumberOfArrowsToBurstBalloonsTask
{
    public int FindMinArrowShots(int[][] points)
    {
        System.Array.Sort(points, MyComparer);
        int count = points.Length;
        int end = points[0][1];
        for (int i = 1; i < points.Length; i++)
        {
            if (points[i][0] <= end)
            {
                end = System.Math.Min(end, points[i][1]);
                count--;
            }
            else
                end = points[i][1];
        }

        return count;
    }

    private int MyComparer(int[] arr1, int[] arr2)
    {
        if (arr1[0] > arr2[0])
            return 1;
        if (arr1[0] == arr2[0])
        {
            if (arr1[1] > arr2[1])
                return 1;
            if (arr1[1] == arr2[1])
                return 0;
            return -1;
        }

        return -1;
    }
}