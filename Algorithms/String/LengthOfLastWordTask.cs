namespace Algorithm_DataStructures.Algorithms.String;

public class LengthOfLastWordTask
{
    public int LengthOfLastWord(string s)
    {
        int lastWordLength = 0;
        for (int i = s.Length - 1; i >= 0; i--)
        {
            if (s[i] != ' ')
                ++lastWordLength;
            else if (lastWordLength != 0)
                break;
        }

        return lastWordLength;
    }
}