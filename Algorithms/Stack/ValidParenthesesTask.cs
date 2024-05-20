namespace Algorithm_DataStructures.Algorithms.Stack;

public class ValidParenthesesTask
{
    public bool IsValid(string s)
    {
        Stack<char> brackets = new Stack<char>();
        char curBracket = '0';
        foreach (char t in s)
        {
            curBracket = t;
            if (curBracket == '(' ||
                curBracket == '{' ||
                curBracket == '[')
                brackets.Push(curBracket);
            else if (brackets.Count != 0)
            {
                switch (curBracket)
                {
                    case ')':
                        if (brackets.Pop() != '(')
                            return false;
                        break;
                    case '}':
                        if (brackets.Pop() != '{')
                            return false;
                        break;
                    case ']':
                        if (brackets.Pop() != '[')
                            return false;
                        break;
                }
            }
            else
                return false;
        }

        return (brackets.Count == 0) ? true : false;
    }
}