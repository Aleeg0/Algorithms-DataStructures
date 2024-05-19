namespace Algorithm_DataStructures.Algorithms.Math;

public class PlusOneTask
{
        public int[] PlusOne(int[] digits)
        {
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                digits[i]++;
                if (digits[i] > 9)
                {
                    digits[i] = 0;
                }
                else
                {
                    break;
                }
            }

            if (digits[0] == 0)
            {
                int[] newDigits = new int[digits.Length + 1];
                newDigits[0] = 1;
                digits.CopyTo(newDigits,1);
                return newDigits;
            }

            return digits;
        }
    
}