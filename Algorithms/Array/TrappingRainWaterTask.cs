namespace Algorithm_DataStructures.Algorithms.Array;

public class TrappingRainWaterTask
{
    public class Solution {
        public int Trap(int[] height)
        {
            int left = 0;
            int right = height.Length - 1;
            int maxLeft = height[left];
            int maxRight = height[right];
            int bricksOfWater = 0;
            int curIndex = left;
            while (left < right)
            {
                int temp = System.Math.Min(maxLeft, maxRight) - height[curIndex];
                // if there are bricks
                if (temp > 0)
                    bricksOfWater += temp;
                // change maxes
                if (curIndex == left)
                    maxLeft = System.Math.Max(height[curIndex], maxLeft);
                else
                    maxRight = System.Math.Max(height[curIndex], maxRight);
                // choose next pointer to shift 
                if (maxRight < maxLeft)
                {
                    right--;
                    curIndex = right;
                    
                }
                else
                {
                    left++;
                    curIndex = left;    
                }
            }

            return bricksOfWater;
        }
    }
}