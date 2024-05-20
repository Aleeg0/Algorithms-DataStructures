namespace Algorithm_DataStructures.Algorithms.LinkedList;

public class RemoveDuplicatesFromSortedL2Task
{
    public ListNode DeleteDuplicates(ListNode head)
    {
        if (head == null)
            return null;
        if (head.next == null)
            return head;
        ListNode answer = new ListNode(0, null);
        ListNode dummy = answer;
        ListNode prev = head;
        ListNode cur = head.next;
        int counter = 1;
        while (prev != null)
        {
            if (cur != null && cur.val == prev.val)
            {
                while (cur != null && cur.val == prev.val)
                    cur = cur.next;
            }
            else
            {
                dummy.next = prev;
                dummy = dummy.next;
            }
            prev = cur;
            cur = cur != null ? cur.next : null;
        }

        dummy.next = null;
        return answer.next;
    }
}