namespace Algorithm_DataStructures.Algorithms.BinaryTree.DFS;

public class MaximumDepthTask
{
    public int MaxDepth(TreeNode root)
    {
        if (root == null)
            return 0;
        int left = MaxDepth(root.left);
        int right = MaxDepth(root.right);
        return (left > right) ? left + 1 : right + 1;
    }
}