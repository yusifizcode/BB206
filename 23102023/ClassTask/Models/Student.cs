namespace ClassTask.Models
{
    internal class Student
    {
        public string Fullname { get; set; }
        public string GroupNo { get; set; }

        public override string ToString()
        {
            return $"{Fullname} - {GroupNo}";
        }
    }
}
