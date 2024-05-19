namespace Algorithm_DataStructures.Algorithms.BinaryTree.BFS;

public class ZigzagLevelOrderTraversal
{
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
    {
        List<IList<int>> answer = new List<IList<int>>();
        if (root == null)
            return answer;
        Queue<TreeNode> q = new Queue<TreeNode>();
        bool RF = false;
        q.Enqueue(root);
        while (q.Count > 0)
        {
            List<int> level = new List<int>();
            int size = q.Count;
            for (int i = 0; i < size; i++)
            {
                TreeNode temp = q.Dequeue();
                level.Add(temp.val);
                if (temp.left != null) q.Enqueue(temp.left);
                if (temp.right != null) q.Enqueue(temp.right);
            }

            if (RF)
                level.Reverse();
            answer.Add(level);
            RF = !RF;
        }

        return answer;
    }
}