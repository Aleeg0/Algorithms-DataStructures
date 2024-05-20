namespace Algorithm_DataStructures.Algorithms.BinaryTree.DFS;

public class ConstructBTFromPreInorderTraversalTask
{
    public TreeNode BuildTree(int[] preorder, int[] inorder)
    {
        if (preorder.Length == 0 || inorder.Length == 0)
            return null;
        int index = Array.IndexOf(inorder, preorder[0]);
        TreeNode node = new TreeNode(preorder[0],
            BuildTree(preorder[1..(index + 1)], inorder[..index]),
            BuildTree(preorder[(index + 1)..],inorder[(index+1)..])
        );
        return node;
    }
}