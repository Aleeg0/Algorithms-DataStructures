namespace Algorithm_DataStructures.Algorithms.Matrix;

public class RotateImageTask
{
    public void Rotate(int[][] matrix)
    {
        int size = matrix.Length;
        int start = 0;
        int count = matrix.Length / 2;
        for (int steps = 0; steps < count; steps++)
        {
            for (int i = start; i < size - 1; i++)
            {
                // first
                var last = matrix[i][size - 1];
                matrix[i][size - 1] = matrix[start][i];
                // second
                (last, matrix[size - 1][size - (i - start) - 1]) = (matrix[size - 1][size - (i - start) - 1], last);
                // third
                (last, matrix[size - (i - start) - 1][start]) = (matrix[size - (i - start) - 1][start], last);
                // fourth
                matrix[start][i] = last;
            }

            size--;
            start++;
        }
    }
}