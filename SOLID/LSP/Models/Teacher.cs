namespace LSP.Models
{
    internal class Teacher : Person, IExperince
    {
        public byte GetExperience()
        {
            Console.WriteLine("Teacher Experincei");
            return 0;
        }

        public override string GetFullData()
        {
            Console.WriteLine("Teacherin FullDatasi");
            return "";
        }

        public override string GetFullname()
        {
            Console.WriteLine("Teacherin Fullnamei");
            return "";
        }
    }
}
