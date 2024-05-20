namespace Algorithm_DataStructures.Algorithms.LinkedList;

public class ReverseNodesInK_GroupTask
{
    public ListNode ReverseKGroup(ListNode head, int k)
    {
        ListNode dummy = new ListNode(0, head);
        ListNode prev = dummy;
        ListNode cur = dummy.next;
        int available = 0;
        while (cur != null)
        {
            available++;
            cur = cur.next;
        }

        cur = dummy.next;
        while (cur != null && available >= k)
        {
            for (int i = 1; i < k; i++)
            {
                ListNode temp = cur.next;
                cur.next = cur.next.next;
                temp.next = prev.next;
                prev.next = temp;
            }
            prev = cur;
            cur = cur.next;
            available -= k;
        }
        
        return dummy.next;
    }
}