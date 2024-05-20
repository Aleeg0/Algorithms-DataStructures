namespace Algorithm_DataStructures.Algorithms.BinaryTree.DFS;

public class Flatten_BTtoLinkedList
{
    public void Flatten(TreeNode root)
    {
        Helper(root);
    }

    public TreeNode Helper(TreeNode root)
    {
        if (root == null) return null;
        TreeNode leftTail = Helper(root.left);
        TreeNode rightTail = Helper(root.right);
        if (leftTail != null)
        {
            leftTail.right = root.right;
            root.right = root.left;
            root.left = null;
        }

        return (rightTail != null) ? rightTail : leftTail ?? root;
    }   
}