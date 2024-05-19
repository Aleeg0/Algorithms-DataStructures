namespace Algorithm_DataStructures.Algorithms.BinarySearchTree;

public class ValidateBSTTask
{
    public class Solution
    {
        private bool answer;
        public bool IsValidBST(TreeNode root)
        {
            return Helper(root,long.MinValue,long.MaxValue);
        }

        public bool Helper(TreeNode root, long lowBound, long highBound)
        {
            if (root == null) return true;
            if (root.val <= lowBound || highBound <= root.val)
                return false;
            return Helper(root.left, lowBound, root.val) && Helper(root.right, root.val, highBound);
        }
    }
}