namespace Algorithm_DataStructures.Algorithms.BinaryTree.DFS;

public class InvertBTTask
{
    public TreeNode InvertTree(TreeNode root)
    {
        if (root == null) return null;
        InvertTree(root.left);
        InvertTree(root.right);
        (root.left, root.right) = (root.right, root.left);
        return root;
    }   
}