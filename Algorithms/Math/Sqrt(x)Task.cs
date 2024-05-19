namespace Algorithm_DataStructures.Algorithms.Math;

public class Sqrt_x_Task
{
    public int MySqrt(int x)
    {
        long i = 0;
        long j = x;
        if (x == 0)
            return 0;
        long root = 1;
        long square;
        while (i < j)
        {
            root = (i + j + 1) / 2;
            square = root * root;
            if (square < (long)x)
            {
                i = root;
            }
            else if (square > (long)x)
            {
                j = root - 1;
            }
            else
                return (int)root;
        }

        return (int)i;
    }
}