namespace Algorithm_DataStructures.Algorithms.String;

public class LongestCommonPrefixTask
{
    public string LongestCommonPrefix(string[] strs)
    {
        bool isEqual = true;
        char curChar = '0';
        string prefix = "";
        for (int i = 0; i < strs[0].Length; i++)
        {
            curChar = strs[0][i];
            for (int j = 1; j < strs.Length; j++)
            {
                if (strs[j].Length == i || strs[j][i] != curChar)
                    goto label1;
            }

            prefix += curChar;
        }

        label1:
        return prefix;
    }
}