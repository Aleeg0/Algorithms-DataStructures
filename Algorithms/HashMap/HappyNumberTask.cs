namespace Algorithm_DataStructures.Algorithms.HashMap;

public class HappyNumberTask
{
    public bool IsHappy(int n)
    {
        HashSet<int> numbers = new HashSet<int>();
        while (!numbers.Contains(n) && n != 1)
        {
            numbers.Add(n);
            int newNumber = 0;
            while (n != 0)
            {
                newNumber += (n % 10) * (n % 10);
                n /= 10;
            }

            n = newNumber;
        }

        return n == 1;
    }
}