namespace ConsoleApp1
{
    public class Human
    {
        public string Name;
        public string Surname;
        public byte Age;

        public Human()
        {

        }

        public Human(string name)
        {
            this.Name = name;
        }

        public Human(string name, string surname) : this(name)
        {
            this.Surname = surname;
        }

        public void ShowFullData()
        {
            Console.WriteLine($"{GetFullName()} {this.Age}");
        }

        public string GetFullName()
        {
            return Name + " " + Surname;
        }
    }
}
