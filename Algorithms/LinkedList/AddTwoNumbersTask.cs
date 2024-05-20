namespace Algorithm_DataStructures.Algorithms.LinkedList;

public class AddTwoNumbersTask
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode sumList = l1;
        ListNode dummy1 = new ListNode(0);
        dummy1.next = l1;
        ListNode dummy2 = new ListNode(0);
        dummy2.next = l2;
        bool CF = false;
        while (dummy1.next != null && dummy2.next != null)
        {
            dummy1 = dummy1.next;
            dummy2 = dummy2.next;
            dummy1.val += dummy2.val + (CF ? 1 : 0);
            if (dummy1.val > 9)
            {
                dummy1.val -= 10;
                CF = true;
            }
            else
                CF = false;
        }
        if (dummy2.next != null)
            dummy1.next = dummy2.next;
        if (dummy1.next != null)
        {
            while (dummy1.next != null)
            {
                dummy1 = dummy1.next;
                dummy1.val += (CF ? 1 : 0);
                if (dummy1.val > 9)
                {
                    dummy1.val -= 10;
                    CF = true;
                }
                else
                    CF = false;
            }
        }

        if (CF)
        {
            dummy1.next = new ListNode(1);
        }

        return sumList;
    }
}