namespace Algorithm_DataStructures.Algorithms.BinaryTree.BFS;

public class AverageofLevelsTask
{
    public IList<double> AverageOfLevels(TreeNode root)
    {
        List<double> answer = new List<double>();
        Queue<TreeNode> q = new Queue<TreeNode>();
        q.Enqueue(root);
        while (q.Count > 0)
        {
            double levelSum = 0;
            int size = q.Count;
            for (int i = 0; i < size; i++)
            {
                TreeNode temp = q.Dequeue();
                levelSum += temp.val;
                if (temp.left != null) q.Enqueue(temp.left);
                if (temp.right != null) q.Enqueue(temp.right);
            }

            answer.Add(levelSum / size);
        }

        return answer;
    }
}   