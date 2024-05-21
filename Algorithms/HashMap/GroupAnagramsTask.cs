namespace Algorithm_DataStructures.Algorithms.HashMap;

public class GroupAnagramsTask
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();

        for (int i = 0; i < strs.Length; i++)
        {
            char[] wordArr = strs[i].ToCharArray();
            System.Array.Sort(wordArr);
            string word = new string(wordArr);
            if (!dictionary.ContainsKey(word))
                dictionary.Add(word, new List<string>());
            dictionary[word].Add(strs[i]);
        }

        IList<IList<string>> answer = new List<IList<string>>();
        foreach (var pair in dictionary)
        {
            answer.Add(pair.Value);
        }

        return answer;
    }
}