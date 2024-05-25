using System.Text;
namespace Algorithm_DataStructures.Algorithms.String;

public class ZigzagConversionTask
{
    public string Convert(string s, int numRows)
    {
        if (numRows == 1)
            return s;
        int basicSteps = (numRows - 1) * 2;
        StringBuilder answer = new StringBuilder();
        // first case
        int j = 0;
        while (j < s.Length)
        {
            answer.Append(s[j]);
            j += basicSteps;
        }

        // middle case
        for (int i = 1; i < numRows - 1; i++)
        {
            int curSteps = (numRows - i - 1) * 2;
            j = i;
            while (j < s.Length)
            {
                answer.Append(s[j]);
                if (curSteps + j < s.Length)
                    answer.Append(s[j + curSteps]);
                j += basicSteps;
            }
        }

        // last case
        j = numRows - 1;
        while (j < s.Length)
        {
            answer.Append(s[j]);
            j += basicSteps;
        }

        return answer.ToString();
    }
}