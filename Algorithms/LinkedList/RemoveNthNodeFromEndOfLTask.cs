namespace Algorithm_DataStructures.Algorithms.LinkedList;

public class RemoveNthNodeFromEndOfLTask
{
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        int size = 0;
        ListNode cur = head;
        while (cur != null)
        {
            cur = cur.next;
            size++;
        }
        int newSize = size - n - 1;
        if (newSize < 0)
        {
            if (size == 1)
                return null;
            return head.next;
        }
        cur = head;
        for (int i = 0; i < newSize; i++)
        {
            cur = cur.next;
        }
        cur.next = cur.next.next;
        return head;
    }
}