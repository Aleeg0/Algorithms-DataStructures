namespace Algorithm_DataStructures.Algorithms.BinaryTree.DFS;

public class ConstructBTfromInPostorderTraversalTask
{
    private int[] _postorder;
    private int[] _inorder;
    public TreeNode BuildTree(int[] inorder, int[] postorder)
    {
        _postorder = postorder;
        _inorder = inorder;
        return Helper(0, postorder.Length, 0, inorder.Length);
    }

    public TreeNode Helper(int postStart, int postEnd, int inStart, int inEnd)
    {
        if (postEnd <= postStart || inEnd <= inStart)
            return null;
        int index = Array.IndexOf(_inorder, _postorder[postEnd-1]);
        TreeNode node = new TreeNode(_postorder[postEnd-1],
            null,
            null);
        node.left = Helper(postStart,postStart + index - inStart,inStart,index);
        node.right = Helper(postStart + index - inStart, postEnd - 1, index+1, inEnd);
        return node;
    }
}