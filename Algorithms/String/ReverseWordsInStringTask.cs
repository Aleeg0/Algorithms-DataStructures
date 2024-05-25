using System.Text;
namespace Algorithm_DataStructures.Algorithms.String;

public class ReverseWordsInStringTask
{
    public string ReverseWords(string s)
    {
        StringBuilder answer = new StringBuilder();
        string tempWord = "";
        int i = s.Length - 1;
        while (i > -1)
        {
            while (i > -1 && s[i] == ' ')
                i--;
            if (i < 0)
                break;
            int j = i;
            while (j > -1 && s[j] != ' ')
                j--;
            answer.Append(s.Substring(j + 1, i - j) + " ");
            i = j;
        }

        if (answer[^1] == ' ')
            answer.Remove(answer.Length - 1, 1);
        return answer.ToString();
    }
}