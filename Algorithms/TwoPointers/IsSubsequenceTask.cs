namespace Algorithm_DataStructures.Algorithms.TwoPointers;

public class IsSubsequenceTask
{
    public bool IsSubsequence(string s, string t)
    {
        if (s.Length == 0)
            return true;
        if (t.Length == 0)
            return false;
        int i1 = 0;
        int i2 = 0;
        while (i2 < t.Length)
        {
            if (s[i1] == t[i2])
                i1++;
            if (i1 == s.Length)
                return true;
            i2++;
        }

        return false;
    }
}