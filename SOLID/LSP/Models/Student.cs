namespace LSP.Models
{
    internal class Student : Person
    {
        public override string GetFullData()
        {
            Console.WriteLine("Studentin FullDatasi");
            return "";
        }

        public override string GetFullname()
        {
            Console.WriteLine("Studentin Fullnamei");
            return "";
        }
    }
}
