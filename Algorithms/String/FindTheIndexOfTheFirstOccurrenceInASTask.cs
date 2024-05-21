namespace Algorithm_DataStructures.Algorithms.String;

public class FindTheIndexOfTheFirstOccurrenceInASTask
{
    public int StrStr(string haystack, string needle)
    {
        if (haystack.Length < needle.Length)
            return -1;
        for (int i = 0; i < haystack.Length; i++)
        {
            int j;
            for (j = 0; j < needle.Length; j++)
            {
                if (haystack.Length <= i + j || haystack[i + j] != needle[j])
                    break;
            }

            if (j == needle.Length && haystack[i + j - 1] == needle[j - 1])
                return i;
        }

        return -1;
    }
}