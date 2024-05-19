namespace Algorithm_DataStructures.Algorithms.BinaryTree.BFS;

public class RightSideViewTask
{

    public IList<int> RightSideView(TreeNode root)
    {
        List<int> answer = new List<int>();
        Queue<TreeNode> q = new Queue<TreeNode>();
        if (root == null)
            return answer;
        q.Enqueue(root);
        while (q.Count > 0)
        {
            int rightValue = 0;
            int size = q.Count;
            for (int i = 0; i < size; i++)
            {
                TreeNode temp = q.Dequeue();
                rightValue = temp.val;
                if (temp.left != null) q.Enqueue(temp.left);
                if (temp.right != null) q.Enqueue(temp.right);
            }

            answer.Add(rightValue);
        }

        return answer;
    }
}