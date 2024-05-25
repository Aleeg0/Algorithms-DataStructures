namespace Algorithm_DataStructures.Algorithms.Array;

public class CandyTask
{
    public int Candy(int[] ratings)
    {
        int[] candiesArr = new int[ratings.Length];
        candiesArr[0] = 1;
        for (int i = 1; i < ratings.Length; i++)
        {
            if (ratings[i - 1] < ratings[i])
                candiesArr[i] = candiesArr[i - 1] + 1;
            else
                candiesArr[i] = 1;
        }

        for (int i = ratings.Length - 2; i >= 0; i--)
        {
            if (ratings[i] > ratings[i + 1] && candiesArr[i] <= candiesArr[i + 1])
                candiesArr[i] = candiesArr[i + 1] + 1;
        }

        return candiesArr.Sum();
    }
}