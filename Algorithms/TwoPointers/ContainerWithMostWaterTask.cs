namespace Algorithm_DataStructures.Algorithms.TwoPointers;

public class ContainerWithMostWaterTask
{
    public int MaxArea(int[] height)
    {
        int left = 0;
        int rigth = height.Length - 1;
        int maxValue = -1;
        while (left < rigth)
        {
            int temp = System.Math.Min(height[left], height[rigth]) * (rigth - left);
            if (temp > maxValue)
                maxValue = temp;
            if (height[left] > height[rigth])
                rigth--;
            else
                left++;
        }

        return maxValue;
    }
}