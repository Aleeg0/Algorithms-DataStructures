namespace Algorithm_DataStructures.Algorithms.BitManipulation;

public class ReverseBitsTask
{
    public uint reverseBits(uint n)
    {
        uint answer = 0;
        for (int i = 0; i < 32; i++)
        {
            answer |= (1 & n) << (31 - i);
            n >>= 1;
        }

        return answer;
    }
}