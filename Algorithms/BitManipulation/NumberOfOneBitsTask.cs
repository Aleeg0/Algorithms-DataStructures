namespace Algorithm_DataStructures.Algorithms.BitManipulation;

public class NumberOfOneBitsTask
{
    public int HammingWeight(int n)
    {
        int count = 0;
        while (n > 0)
        {
            count += n & 1;
            n >>= 1;
        }

        return count;
    }
}