namespace Algorithm_DataStructures.Algorithms.LinkedList;

public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode()
    {
        val = 0;
        next = null;
    }
    public ListNode(int x)
    {
        val = x;
        next = null;
    }
    public ListNode(int val=0, ListNode next=null) {
                 this.val = val;
                 this.next = next;
    }
}
