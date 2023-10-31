namespace LSP.Models
{
    internal class Professor : Person, IExperince
    {
        public byte GetExperience()
        {
            Console.WriteLine("Professorun Experincei");
            return 0;
        }

        public override string GetFullData()
        {
            Console.WriteLine("Professorunin FullDatasi");
            return "";
        }

        public override string GetFullname()
        {
            Console.WriteLine("Professorunin Fullnamei");
            return "";
        }
    }
}
