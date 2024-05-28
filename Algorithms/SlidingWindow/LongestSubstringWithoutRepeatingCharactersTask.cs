namespace Algorithm_DataStructures.Algorithms.SlidingWindow;

public class LongestSubstringWithoutRepeatingCharactersTask
{
    public int LengthOfLongestSubstring(string s)
    {
        HashSet<char> charSet = new HashSet<char>();
        int n = s.Length;
        int left = 0;
        int maxLength = 0;
        for (int i = 0; i < n; i++)
        {
            if (!charSet.Contains(s[i]))
            {
                charSet.Add(s[i]);
                maxLength = (maxLength > i - left + 1) ? maxLength : i - left + 1;
            }
            else
            {
                while (charSet.Contains(s[i]))
                    charSet.Remove(s[left++]);
                charSet.Add(s[i]);
            }
        }

        return maxLength;
    }
}