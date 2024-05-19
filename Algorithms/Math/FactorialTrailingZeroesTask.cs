namespace Algorithm_DataStructures.Algorithms.Math;

public class FactorialTrailingZeroesTask
{
    public int TrailingZeroes(int n)
    {
        int answer = 0;
        for (int i = 5; i <= n; i *= 5)
        {
            answer += n / i;
        }

        return answer;
    }
}