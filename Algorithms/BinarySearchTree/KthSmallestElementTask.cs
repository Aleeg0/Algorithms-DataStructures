namespace Algorithm_DataStructures.Algorithms.BinarySearchTree;

public class KthSmallestElementTask
{

    private int answer;
    private int k;

    public int KthSmallest(TreeNode root, int k)
    {
        this.k = k;
        Helper(root);
        return answer;
    }

    private void Helper(TreeNode root)
    {
        if (root == null) return;
        Helper(root.left);
        if (k > 0)
        {
            k--;
            if (k == 0) answer = root.val;
        }

        Helper(root.right);
    }
}