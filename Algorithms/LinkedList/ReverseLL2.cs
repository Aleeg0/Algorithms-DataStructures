namespace Algorithm_DataStructures.Algorithms.LinkedList;

public class ReverseLL2
{
    public ListNode ReverseBetween(ListNode head, int left, int right)
    {
        ListNode dummy = new ListNode(0, head);
        ListNode current = dummy;
        for (int i = 1; i < left; i++)
        {
            current = current.next;
        }
        ListNode prev = current;
        current = current.next;
        for (int i = 0; i < right-left; i++)
        {
            ListNode temp = current.next;
            current.next = current.next.next;
            temp.next = prev.next;
            prev.next = temp;
        }

        return dummy.next;
    }
}