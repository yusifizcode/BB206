namespace _23102023
{
    internal class PhoneList<T, U>
    {
        public T[] Names = new T[0];
        public U[] PhoneNumbers = new U[0];


        public void Add(T name, U phoneNumber)
        {
            Array.Resize(ref Names, Names.Length + 1);
            Names[Names.Length - 1] = name;
            Array.Resize(ref PhoneNumbers, PhoneNumbers.Length + 1);
            PhoneNumbers[PhoneNumbers.Length - 1] = phoneNumber;
        }
    }
}
