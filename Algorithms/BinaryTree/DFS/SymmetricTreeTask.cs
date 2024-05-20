namespace Algorithm_DataStructures.Algorithms.BinaryTree.DFS;

public class SymmetricTreeTask
{
    public bool IsSymmetric(TreeNode root)
    {
        return IsMerror(root.left, root.right);
    }

    private bool IsMerror(TreeNode rootLeft, TreeNode rootRight)
    {
        if (rootLeft == null || rootRight == null)
            return rootLeft == rootRight;
        return rootRight.val == rootLeft.val && IsMerror(rootLeft.left, rootRight.right) &&
               IsMerror(rootLeft.right, rootRight.left);
    }
}