namespace Inheritance_Encapsulation
{
    public class Human
    {
        public Human(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        private byte _age;
        public byte Age
        {
            get => _age;
            set
            {
                if (value > 0)
                {
                    _age = value;
                }
            }
        }

    }
}
