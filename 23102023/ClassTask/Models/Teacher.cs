namespace ClassTask.Models
{
    internal class Teacher
    {
        public string Fullname { get; set; }
        public byte Experience { get; set; }

        public override string ToString()
        {
            return $"{Fullname} - {Experience}";
        }
    }
}
