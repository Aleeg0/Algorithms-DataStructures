namespace Algorithm_DataStructures.Algorithms.Array;

public class HIndexTask
{
    public int HIndex(int[] citations)
    {
        int size = citations.Length;
        int[] countArr = new int[size + 1];
        System.Array.Fill(countArr, 0);
        for (int i = 0; i < size; i++)
        {
            if (citations[i] > size)
                countArr[size]++;
            else
                countArr[citations[i]]++;
        }

        int j = 0;
        for (int i = 0; i < size; i++)
        {
            while (countArr[j] == 0)
            {
                j++;
            }

            citations[i] = j;
            countArr[j]--;
        }

        int max = 0;
        for (int i = 1; i <= size; i++)
        {
            if (citations[^i] >= i)
                max = i;
        }

        return max;
    }
}