namespace _23102023
{
    internal class DoubleList
    {
        public double[] _strings = new double[0];

        public void Add(double value)
        {
            Array.Resize(ref _strings, _strings.Length + 1);
            _strings[^1] = value;
        }

        public void AddRange(double[] values)
        {
            for (int i = 0; i < values.Length; i++)
            {
                Add(values[i]);
            }
        }

        public int Count { get => _strings.Length; }
    }
}
