namespace Algorithm_DataStructures.DataStructures;

public class LRUCache
{
    private int _capacity;

    private class DLinkedList
    {
        private class Node
        {
            public int key;
            public Node prev;
            public Node next;

            public Node(int key, Node prev, Node next)
            {
                this.key = key;
                this.prev = prev;
                this.next = next;
            }
        }

        public DLinkedList()
        {
            lastRecent = null;
            mostRecent = null;
            Count = 0;
        }

        public int Count { get; private set; }

        private Node mostRecent;
        private Node lastRecent;

        public int PopFirst()
        {
            int removedKey = lastRecent.key;
            if (lastRecent.next == null)
                mostRecent = null;
            lastRecent = lastRecent.next;
            if (lastRecent != null)
                lastRecent.prev = null;
            Count--;
            return removedKey;
        }

        public void PushLast(int key)
        {
            if (mostRecent == null)
            {
                lastRecent = new Node(key, null, null);
                mostRecent = lastRecent;
            }
            else
            {
                mostRecent.next = new Node(key, mostRecent, null);
                mostRecent = mostRecent.next;
            }

            Count++;
        }

        public void Remove(int key)
        {
            Node cur = lastRecent;
            while (cur.key != key)
                cur = cur.next;
            if (cur.prev != null)
                cur.prev.next = cur.next;
            if (cur.next != null)
                cur.next.prev = cur.prev;
            if (cur == lastRecent)
                lastRecent = cur.next;
            if (cur == mostRecent)
                mostRecent = cur.prev;
        }

    }

    private Dictionary<int, int> map;
    private DLinkedList dLList;

    public LRUCache(int capacity)
    {
        _capacity = capacity;
        map = new Dictionary<int, int>(_capacity);
        dLList = new DLinkedList();
    }

    public int Get(int key)
    {
        if (map.TryGetValue(key, out var value))
        {
            dLList.Remove(key);
            dLList.PushLast(key);
            return value;
        }

        return -1;
    }

    public void Put(int key, int value)
    {
        if (dLList.Count + 1 > _capacity)
        {
            int removedKey = key;
            if (map.ContainsKey(key))
                dLList.Remove(key);
            else
                removedKey = dLList.PopFirst();
            if (removedKey != key)
                map.Remove(removedKey);
        }

        map[key] = value;
        dLList.PushLast(key);
    }
}