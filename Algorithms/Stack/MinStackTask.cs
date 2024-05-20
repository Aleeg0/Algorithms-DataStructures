namespace Algorithm_DataStructures.Algorithms.Stack;

public class MinStackTask
{
    public class MinStack
    {

        private List<int> _list;
        private int _top;
        private int min;
    
        public MinStack()
        {
            _list = new List<int>();
            _top = -1;
        }
    
        public void Push(int val)
        {
            if (_top == -1)
                min = val;
            else if (val < min)
                min = val;
            _list.Add(val);
            _top++;
        }
    
        public void Pop() {
            if (_list[_top] == min && _top != 0)
            {
                min = _list[_top-1];
                for (int i = 0; i < _top - 1; i++)
                {
                    if (min > _list[i])
                        min = _list[i];
                }
            }
            _list.RemoveAt(_top--);
        }
    
        public int Top()
        {
            return _list[_top];
        }
    
        public int GetMin()
        {
            return min;
        }
    }
}