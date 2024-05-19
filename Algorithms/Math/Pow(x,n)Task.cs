namespace Algorithm_DataStructures.Algorithms.Math;

public class Pow_x_n_Task
{
    public double MyPow(double x, int n)
    {
        if (n == 0 || x == 1)
            return 1;
        double answer = 1;
        long tempN = (n > 0) ? n : -(long)n;
        while (tempN > 0)
        {
            if (tempN % 2 == 0)
            {
                x *= x;
                tempN /= 2;
            }
            else
            {
                answer *= x;
                tempN--;
            }
        }

        return (n < 0) ? 1 / answer : answer;
    }
}