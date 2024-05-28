namespace Algorithm_DataStructures.Algorithms.BitManipulation;

public class BitwiseANDOfNumbersRangeTask
{
    public int RangeBitwiseAnd(int left, int right)
    {
        int answer = 0;
        int curCoef = 1;
        while (left > 0)
        {
            if ((left & 1) == 1 && right - left == 0)
                answer += curCoef;
            curCoef <<= 1;
            left >>= 1;
            right >>= 1;
        }

        return answer;
    }
}