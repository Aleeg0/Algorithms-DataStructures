namespace Algorithm_DataStructures.Algorithms.String;

public class RomanToIntegerTask
{
    public int RomanToInt(string s)
    {
        if (s.Length == 0)
            return 0;
        char prev = s[0];
        int sum = GiveValue(s[0]);
        for (int i = 1; i < s.Length; i++)
        {
            switch (s[i])
            {
                case 'I':
                {
                    prev = 'I';
                    sum += 1;
                }
                    break;
                case 'V':
                {
                    if (prev == 'I')
                        sum += 3;
                    else
                        sum += 5;
                    prev = 'V';
                }
                    break;
                case 'X':
                {
                    if (prev == 'I')
                        sum += 8;
                    else
                        sum += 10;
                    prev = 'X';
                }
                    break;
                case 'L':
                {
                    if (prev == 'X')
                        sum += 30;
                    else
                        sum += 50;
                    prev = 'L';
                }
                    break;
                case 'C':
                {
                    if (prev == 'X')
                        sum += 80;
                    else
                        sum += 100;
                    prev = 'C';
                }
                    break;
                case 'D':
                {
                    if (prev == 'C')
                        sum += 300;
                    else
                        sum += 500;
                    prev = 'D';
                }
                    break;
                case 'M':
                {
                    if (prev == 'C')
                        sum += 800;
                    else
                        sum += 1000;
                    prev = 'M';
                }
                    break;
            }
        }

        return sum;
    }

    public int GiveValue(char ch)
    {
        int value = 0;
        switch (ch)
        {
            case 'I':
                value = 1;
                break;
            case 'V':
                value = 5;
                break;
            case 'X':
                value = 10;
                break;
            case 'L':
                value = 50;
                break;
            case 'C':
                value = 100;
                break;
            case 'D':
                value = 500;
                break;
            case 'M':
                value = 1000;
                break;
        }

        return value;
    }
}