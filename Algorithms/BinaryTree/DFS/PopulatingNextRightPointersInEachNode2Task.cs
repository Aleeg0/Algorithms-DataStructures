namespace Algorithm_DataStructures.Algorithms.BinaryTree.DFS;

public class PopulatingNextRightPointersInEachNode2Task
{
    public Node Connect(Node root)
    {
        if (root == null) return root;
        Queue<Node> q = new Queue<Node>();
        q.Enqueue(root);
        while (q.Count > 0)
        {
            int size = q.Count;
            Node temp = null;
            for (int i = 1; i < size; i++)
            {
                temp = q.Dequeue();
                temp.next = q.Peek();
                if (temp.left != null) q.Enqueue(temp.left);
                if (temp.right != null) q.Enqueue(temp.right);
            }
            temp = q.Dequeue();
            temp.next = null;
            if (temp.left != null) q.Enqueue(temp.left);
            if (temp.right != null) q.Enqueue(temp.right);
        }
        return root;
    }
}