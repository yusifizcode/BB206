namespace ClassTask.Models
{
    internal class MyList<T>
    {
        public T[] values = Array.Empty<T>();

        public void Add(T item)
        {
            Array.Resize(ref values, values.Length + 1);
            values[values.Length - 1] = item;
        }

        public void AddRange(T[] values)
        {
            for (int i = 0; i < values.Length; i++)
            {
                Add(values[i]);
            }
        }

        public int Count { get => values.Length; }
    }
}
