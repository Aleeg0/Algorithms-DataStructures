namespace Algorithm_DataStructures.Algorithms.BinaryTree.DFS;

public class PathSumTask
{
    public bool HasPathSum(TreeNode root, int targetSum)
    {
        return helper(root, 0, targetSum);
    }

    private bool helper(TreeNode root, int curSum, int targetSum)
    {
        if (root == null)
            return false;
        curSum += root.val;
        if (root.left == null && root.right == null && curSum == targetSum)
            return  true;
        return helper(root.left, curSum, targetSum) || helper(root.right, curSum, targetSum);
    }
}