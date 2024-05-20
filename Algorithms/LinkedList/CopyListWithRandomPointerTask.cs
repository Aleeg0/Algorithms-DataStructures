namespace Algorithm_DataStructures.Algorithms.LinkedList;

public class CopyListWithRandomPointerTask
{
    public Node CopyRandomList(Node head)
    {
        if (head == null)
            return null;
        Dictionary<Node, Node> copy = new Dictionary<Node, Node>();
        Node cur = head;
        while (cur != null)
        {
            copy[cur] = new Node(cur.val);
            cur = cur.next;
        }
        cur = head;
        while (cur != null)
        {
            copy[cur].next = cur.next != null ? copy[cur.next]: null;
            copy[cur].random = cur.random != null ? copy[cur.random] : null;
            cur = cur.next;
        }

        return copy[head];
    }
}