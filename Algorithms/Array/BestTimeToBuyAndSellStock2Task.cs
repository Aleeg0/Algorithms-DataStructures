namespace Algorithm_DataStructures.Algorithms.Array;

public class BestTimeToBuyAndSellStock2Task
{
    public int MaxProfit(int[] prices)
    {
        int max = 0;
        for (int i = 1; i < prices.Length; i++)
        {
            if (prices[i - 1] < prices[i])
                max += prices[i] - prices[i - 1];
        }

        return max;
    }
}