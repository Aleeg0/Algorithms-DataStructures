namespace Algorithm_DataStructures.Algorithms.Matrix;

public class SpiralMatrixTask
{
    public IList<int> SpiralOrder(int[][] matrix)
    {
        int L = 0;
        int R = matrix[0].Length;
        int T = 0;
        int B = matrix.Length;
        List<int> answer = new List<int>();
        while (L < R && T < B)
        {
            for (int i = L; i < R; i++)
            {
                answer.Add(matrix[T][i]);
            }

            T++;
            for (int i = T; i < B; i++)
            {
                answer.Add(matrix[i][R - 1]);
            }

            R--;
            if (!(L < R && T < B))
                break;
            for (int i = R - 1; i >= L; i--)
            {
                answer.Add(matrix[B - 1][i]);
            }

            B--;
            for (int i = B - 1; i >= T; i--)
            {
                answer.Add(matrix[i][L]);
            }

            L++;
        }

        return answer;
    }
}