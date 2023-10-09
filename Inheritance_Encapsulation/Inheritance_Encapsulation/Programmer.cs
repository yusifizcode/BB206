namespace Inheritance_Encapsulation
{
    internal class Programmer : Human
    {
        public int Experience { get; set; }
        public Programmer(string name, string surname, int experience) : base(name, surname)
        {
            Experience = experience;
        }
    }
}
