namespace Algorithm_DataStructures.Algorithms.BitManipulation;

public class AddBinaryTask
{
    public string AddBinary(string a, string b)
    {
        string c = "";
        if (a.Length != b.Length)
        {
            if (a.Length < b.Length)
            {
                for (int i = 0; i < b.Length - a.Length; i++)
                    c += '0';
                a = a.Insert(0, c);
            }
            else //a.Length > b.Length
            {
                for (int i = 0; i < a.Length - b.Length; i++)
                    c += '0';
                b = b.Insert(0, c);
            }

            c = "";
        }

        bool CF = false; // carry Flag
        for (int i = a.Length - 1; i >= 0; i--)
        {
            if (a[i] != b[i])
            {
                if (CF)
                    c = c.Insert(0, "0");
                else
                    c = c.Insert(0, "1");
            }
            else if (a[i] == b[i] && a[i] == '1')
            {
                if (CF)
                    c = c.Insert(0, "1");
                else
                {
                    CF = true;
                    c = c.Insert(0, "0");
                }
            }
            else // a[i] == b[j] && a[i] == '0'
            {
                if (CF)
                {
                    CF = false;
                    c = c.Insert(0, "1");
                }
                else
                    c = c.Insert(0, "0");
            }
        }

        if (CF)
        {
            c = c.Insert(0, "1");
        }

        return c;
    }
}