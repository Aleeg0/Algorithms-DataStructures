namespace Algorithm_DataStructures.Algorithms.BinaryTree.DFS;

public class CountCompleteTreeNodesTask
{
    public int CountNodes(TreeNode root) {
        if (root == null) return 0;
        return CountNodes(root.left) + CountNodes(root.right) + 1;     
    }
}