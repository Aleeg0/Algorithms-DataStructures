namespace Algorithm_DataStructures.Algorithms.BinarySearchTree;

public class MinimumAbsoluteDifferenceTask
{

    private int _min;

    private TreeNode prev;

    public int GetMinimumDifference(TreeNode root)
    {
        _min = 100001;
        prev = null;
        Helper(root);
        return _min;
    }

    private void Helper(TreeNode root)
    {
        if (root == null)
            return;
        Helper(root.left);
        if (prev != null)
        {
            _min = int.Min(_min, System.Math.Abs(prev.val - root.val));
            
        }

        prev = root;
        Helper(root.right);
    }

}