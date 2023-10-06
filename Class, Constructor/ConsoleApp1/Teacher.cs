public class Teacher
{
    public string Name;
    public string Surname;
    public byte Age;
    public string Profession;

    public Teacher()
    {

    }

    public Teacher(string name)
    {
        this.Name = name;
    }

    public Teacher(string name, string surname) : this(name)
    {
        this.Surname = surname;
    }

    public void ShowFullData()
    {
        Console.WriteLine($"{GetFullName()} {this.Age} {this.Profession}");
    }

    public string GetFullName()
    {
        return Name + " " + Surname;
    }
}