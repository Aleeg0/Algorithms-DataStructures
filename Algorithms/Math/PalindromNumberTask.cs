namespace Algorithm_DataStructures.Algorithms.Math;

public class PalindromNumberTask
{
    public bool IsPalindrome(int x)
    {
        string s = x.ToString();
        int i = 0;
        int j = s.Length - 1;
        while (i <= j && s[i] == s[j])
        {
            i++;
            j--;
        }

        return (i > j);
    }
}
