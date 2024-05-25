namespace Algorithm_DataStructures.Algorithms.Array;

public class GasStationTask
{
    public int CanCompleteCircuit(int[] gas, int[] cost)
    {
        int difSum = 0;
        int startIndex = -1;
        int curGas = 0;
        for (int i = 0; i < gas.Length; i++)
        {
            int tempDif = gas[i] - cost[i];
            difSum += tempDif;
            curGas += tempDif;
            if (curGas < 0)
            {
                curGas = 0;
                startIndex = -1;
            }
            else if (startIndex == -1)
            {
                startIndex = i;
            }
        }

        return difSum >= 0 ? startIndex : -1;
    }
}