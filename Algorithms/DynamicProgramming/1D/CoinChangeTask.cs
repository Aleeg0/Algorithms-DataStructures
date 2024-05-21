namespace Algorithm_DataStructures.Algorithms.DynamicProgramming._1D;

public class CoinChangeTask
{

    public int CoinChange(int[] coins, int amount)
    {
        const int INF = 10001;
        int[] bestSolution = new int[amount + 1];
        System.Array.Fill(bestSolution, INF);
        System.Array.Sort(coins);
        bestSolution[0] = 0;
        for (int i = 1; i < bestSolution.Length; i++)
        {
            int j = 0;
            while (j < coins.Length && coins[j] <= i)
            {
                int temp = bestSolution[i - coins[j]] + 1;
                if (bestSolution[i] > temp)
                    bestSolution[i] = temp;
                j++;
            }
        }

        return bestSolution[amount] != INF ? bestSolution[amount] : -1;
    }
}