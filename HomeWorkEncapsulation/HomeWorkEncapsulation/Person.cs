namespace HomeWorkEncapsulation
{
    public class Person
    {
        private byte _age;
        private string _fullName;
        public string FullName
        {
            get => _fullName;
            set
            {
                if (value[0] >= 'A' && value[0] <= 'Z')
                {
                    for (int i = 0; i < value.Length - 1; i++)
                    {
                        if (value[i] == ' ' && value[i + 1] >= 'A' && value[i + 1] <= 'Z')
                        {
                            _fullName = value;
                        }
                    }
                }

            }
        }
        public byte Age
        {
            get => _age;
            set
            {
                if (value > 0) _age = value;
            }
        }
        public string PhoneNumber { get; set; }

        public Person(byte age, string fullName, string phoneNumber)
        {
            Age = age;
            FullName = fullName;
            PhoneNumber = phoneNumber;
        }
    }
}
