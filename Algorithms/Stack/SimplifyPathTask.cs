namespace Algorithm_DataStructures.Algorithms.Stack;
using System.Text;

public class SimplifyPathTask
{
    public string SimplifyPath(string path)
    {
        List<string> arr = new List<string>(path.Split('/'));
        while (arr.Contains("")) arr.Remove("");
        Stack<string> helper = new Stack<string>();
        for (int i = 0; i < arr.Count; i++)
        {
            if (arr[i] == ".." && helper.Count > 0)
                helper.Pop();
            else if (arr[i] != "." && arr[i] != "..")
                helper.Push(arr[i]);
        }

        StringBuilder answer = new StringBuilder();
        foreach (var str in helper)
        {
            answer.Insert(0, "/" + str);
        }

        return answer.Length == 0 ? "/" : answer.ToString();
    }
}