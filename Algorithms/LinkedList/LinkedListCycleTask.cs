namespace Algorithm_DataStructures.Algorithms.LinkedList;

public class LinkedListCycleTask
{
    public bool HasCycle(ListNode head)
    {
        ListNode first = head;
        ListNode second = head;
        while (first != null && second != null && second.next != null)
        {
            first = first.next;
            second = second.next.next;
            if (first == second)
                return true;
        }

        return false;
    }
}