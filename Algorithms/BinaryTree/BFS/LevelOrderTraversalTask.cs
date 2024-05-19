namespace Algorithm_DataStructures.Algorithms.BinaryTree.BFS;

public class LevelOrderTraversalTask
{
    public IList<IList<int>> LevelOrder(TreeNode root)
    {
        List<IList<int>> answer = new List<IList<int>>();
        Queue<TreeNode> q = new Queue<TreeNode>();
        if (root == null)
            return answer;
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

            answer.Add(level);
        }

        return answer;
    }
}