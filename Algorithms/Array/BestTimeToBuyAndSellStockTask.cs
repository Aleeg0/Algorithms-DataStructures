namespace Algorithm_DataStructures.Algorithms.Array;

public class BestTimeToBuyAndSellStockTask
{
    public int MaxProfit(int[] prices)
    {
        int size = prices.Length;
        if (size == 0)
            return 0;
        int min = prices[0];
        int profit = 0;
        for (int i = 1; i < size; i++)
        {
            if (prices[i] < min)
                min = prices[i];
            profit = int.Max(profit, prices[i] - min);
        }

        return profit;
    }
}