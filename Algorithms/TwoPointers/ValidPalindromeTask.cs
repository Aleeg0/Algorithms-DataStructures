namespace Algorithm_DataStructures.Algorithms.TwoPointers;

public class ValidPalindromeTask
{
    public bool IsPalindrome(string s)
    {
        int i = 0;
        int j = s.Length - 1;
        s = s.ToLower();
        bool isPal = true;
        while (i < j && isPal)
        {
            while (i < s.Length - 1 && !char.IsLetter(s[i]) && !char.IsDigit(s[i]))
            {
                i++;
            }

            while (i < s.Length - 1 && !char.IsLetter(s[j]) && !char.IsDigit(s[j]))
            {
                j--;
            }

            if (s[i] != s[j])
                isPal = false;
            i++;
            j--;
        }

        return isPal;
    }
}