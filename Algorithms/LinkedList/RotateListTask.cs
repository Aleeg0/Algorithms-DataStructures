namespace Algorithm_DataStructures.Algorithms.LinkedList;

public class RotateListTask
{
    public ListNode RotateRight(ListNode head, int k)
    {
        if (head == null)
            return null;
        int size = 0;
        ListNode cur = head;
        while (cur != null)
        {
            size++;
            cur = cur.next;
        }
        int offset = k > size ? k % size : k;
        head = Rotator(head,0,size - 1);
        head = Rotator(head, 0, offset - 1);
        return Rotator(head,offset,size - 1);
    }

    public ListNode Rotator(ListNode head, int start, int end)
    {
        ListNode dummy = new ListNode(0, head);
        ListNode prev = dummy;
        for (int i = 0; i < start; i++)
        {
            prev = prev.next;
        }
        ListNode current = prev.next;
        for (int i = 0; i < end - start; i++)
        {
            ListNode temp = current.next;
            current.next = current.next.next;
            temp.next = prev.next;
            prev.next = temp;
        }
        return dummy.next;
    }
}