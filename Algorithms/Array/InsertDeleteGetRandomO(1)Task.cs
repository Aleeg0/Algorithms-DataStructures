namespace Algorithm_DataStructures.Algorithms.Array;

public class InsertDeleteGetRandomO_1_Task
{
    public class RandomizedSet
    {
        private Dictionary<int, int> _map;
        private List<int> _nums;
        private Random _rnd;
    
        public RandomizedSet()
        {
            _map = new Dictionary<int, int>();
            _nums = new List<int>();
            _rnd = new Random();
        }
    
        public bool Insert(int val)
        {
            if (_map.ContainsKey(val)) return false;
            _map.Add(val,_nums.Count);
            _nums.Add(val);
            return true;
        }
    
        public bool Remove(int val)
        {
            if (!_map.TryGetValue(val, out int index)) return false;
            _nums[index] = _nums[^1];
            _map[_nums[^1]] = index;
            _nums.RemoveAt(_nums.Count - 1);
            _map.Remove(val);
            return true;
        }
    
        public int GetRandom()
        {
            return _nums[_rnd.Next(_nums.Count)];
        }
    }
}