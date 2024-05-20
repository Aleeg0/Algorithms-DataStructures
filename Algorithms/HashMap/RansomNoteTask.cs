namespace Algorithm_DataStructures.Algorithms.HashMap;

public class RansomNoteTask
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        Dictionary<char, int> dictionary = new Dictionary<char, int>();
        for (int i = 0; i < magazine.Length; i++)
        {
            if (!dictionary.ContainsKey(magazine[i]))
                dictionary.Add(magazine[i], 0);
            dictionary[magazine[i]]++;
        }

        for (int i = 0; i < ransomNote.Length; i++)
        {
            if (!dictionary.ContainsKey(ransomNote[i]))
                return false;
            if (dictionary[ransomNote[i]] == 0)
                return false;
            dictionary[ransomNote[i]]--;
        }

        return true;
    }
}