namespace Algorithm_DataStructures.Algorithms.HashMap;

public class ValidAnagramTask
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
            return false;
        Dictionary<char, int> sDictionary = new Dictionary<char, int>();
        for (int i = 0; i < s.Length; i++)
        {
            if (!sDictionary.ContainsKey(s[i]))
                sDictionary.Add(s[i], 0);
            sDictionary[s[i]]++;
        }

        for (int i = 0; i < t.Length; i++)
        {
            if (!sDictionary.ContainsKey(t[i]) || sDictionary[t[i]] == 0)
                return false;
            sDictionary[t[i]]--;
        }

        return true;
    }
}