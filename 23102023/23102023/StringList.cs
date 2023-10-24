namespace _23102023
{
    internal class StringList
    {
        public string[] _strings = Array.Empty<string>();

        public void Add(string value)
        {
            Array.Resize(ref _strings, _strings.Length + 1);
            _strings[^1] = value;
        }

        public void AddRange(string[] values)
        {
            for (int i = 0; i < values.Length; i++)
            {
                Add(values[i]);
            }
        }

        public int Count { get => _strings.Length; }
    }
}
