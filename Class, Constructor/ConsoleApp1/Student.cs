namespace ConsoleApp1
{
    public class Student
    {
        public string Name;
        public string Surname;
        public byte Age;
        public int Point;
        public Student()
        {

        }

        public Student(string name)
        {
            this.Name = name;
        }

        public Student(string name, string surname) : this(name)
        {
            this.Surname = surname;
        }

        public void ShowFullData()
        {
            Console.WriteLine($"{GetFullName()} {this.Age} {this.Point}");
        }

        public string GetFullName()
        {
            return Name + " " + Surname;
        }
    }
}
