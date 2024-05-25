using System.Text;

namespace Algorithm_DataStructures.Algorithms.String;

public class IntegerToRomanTask
{
    private int[] _nums = [1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1];
    private string[] _symbols = ["M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I"];

    public string IntToRoman(int num)
    {
        StringBuilder answer = new StringBuilder();
        int i = 0;
        while (num > 0)
        {
            if (num >= _nums[i])
            {
                num -= _nums[i];
                answer.Append(_symbols[i]);
            }
            else
                i++;
        }

        return answer.ToString();
    }
}