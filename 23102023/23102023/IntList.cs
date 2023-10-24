namespace _23102023
{
    internal class IntList
    {
        public int[] _intArr = new int[0];

        public void Add(int value)
        {
            Array.Resize(ref _intArr, _intArr.Length + 1);
            _intArr[^1] = value;
        }

        public void AddRange(int[] values)
        {
            for (int i = 0; i < values.Length; i++)
            {
                Add(values[i]);
            }
        }

        public int Count { get => _intArr.Length; }
    }
}
