namespace Algorithm_DataStructures.Algorithms.TwoPointers;

public class TwoSum2Task
{
    public int[] TwoSum(int[] numbers, int target)
    {
        int left = 0;
        int rigth = numbers.Length - 1;
        while (left < rigth)
        {
            if (numbers[left] + numbers[rigth] < target)
                left++;
            else if (numbers[left] + numbers[rigth] > target)
                rigth--;
            else
                break;
        }

        return [left + 1, rigth + 1];
    }
}