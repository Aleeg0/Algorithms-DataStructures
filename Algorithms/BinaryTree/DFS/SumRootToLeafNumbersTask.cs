namespace Algorithm_DataStructures.Algorithms.BinaryTree.DFS;

public class SumRootToLeafNumbersTask
{
    public int SumNumbers(TreeNode root)
    {
        return Helper(root, 0);
    }

    private int Helper(TreeNode root, int curNumber)
    {
        if (root == null) return 0;
        curNumber = curNumber * 10 + root.val;
        if (root != null && root.left == null && root.right == null) 
            return curNumber;
        return Helper(root.left, curNumber) + Helper(root.right, curNumber);
    }
}