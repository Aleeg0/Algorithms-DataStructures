namespace Algorithm_DataStructures.Algorithms.BinaryTree.DFS;

public class SameTreeTask
{
    public bool IsSameTree(TreeNode p, TreeNode q) {
        if (p == null && q == null)
            return true;
        if (p != null && q != null && p.val == q.val)
            return (IsSameTree(p.left, q.left)) && IsSameTree(p.right, q.right);
        return false;
    }
}