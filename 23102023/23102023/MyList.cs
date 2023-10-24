namespace _23102023
{
    internal class MyList<T> where T : class, new()
    {
        public T[] _values = Array.Empty<T>();

        public void Add(T value)
        {
            Array.Resize(ref _values, _values.Length + 1);
            _values[^1] = value;
        }

        public void AddRange(T[] values)
        {
            for (int i = 0; i < values.Length; i++)
            {
                Add(values[i]);
            }
        }

        public int Count { get => _values.Length; }
    }
}
