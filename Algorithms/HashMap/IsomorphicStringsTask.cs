namespace Algorithm_DataStructures.Algorithms.HashMap;

public class IsomorphicStringsTask
{
    public bool IsIsomorphic(string s, string t)
    {
        if (s.Length != t.Length)
            return false;
        var dicS = new Dictionary<char, char>();
        var dicT = new Dictionary<char, char>();
        for (int i = 0; i < s.Length; i++)
        {
            if (dicS.ContainsKey(s[i]) && dicS[s[i]] != t[i] || dicT.ContainsKey(t[i]) && dicT[t[i]] != s[i])
                return false;
            dicS[s[i]] = t[i];
            dicT[t[i]] = s[i];
        }

        return true;
    }
}