namespace Algorithm_DataStructures.Algorithms.DynamicProgramming._1D;

public class ClimbingStairsTask
{
    public int ClimbStairs(int n)
    {
        int[] arr = new int[n + 1];
        arr[0] = 1;
        arr[1] = 1;
        for (int i = 2; i < arr.Length; i++)
        {
            arr[i] = arr[i - 1] + arr[i - 2];
        }

        return arr[n];
    }
}