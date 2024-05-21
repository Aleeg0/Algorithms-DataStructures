namespace Algorithm_DataStructures.Algorithms.Array;

public class MergeSortedArrayTask
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int i = m - 1;
        int j = n - 1;
        int k = n + m - 1;
        while (j > -1)
        {
            if (i > -1 && nums1[i] > nums2[j])
            {
                nums1[k--] = nums1[i--];
            }
            else
                nums1[k--] = nums2[j--];
        }
    }
}