namespace Algorithm_DataStructures.Algorithms.HashMap;

public class WordPatternTask
{
    public bool WordPattern(string pattern, string s)
    {
        Dictionary<char, string> dicP = new Dictionary<char, string>();
        Dictionary<string, char> dicS = new Dictionary<string, char>();
        String[] arrS = s.Split(' ');
        if (arrS.Length != pattern.Length)
            return false;
        for (int i = 0; i < pattern.Length; i++)
        {
            if ((dicP.ContainsKey(pattern[i]) && dicP[pattern[i]] != arrS[i]) ||
                (dicS.ContainsKey(arrS[i]) && dicS[arrS[i]] != pattern[i]))
                return false;
            dicP[pattern[i]] = arrS[i];
            dicS[arrS[i]] = pattern[i];
        }

        return true;
    }
}