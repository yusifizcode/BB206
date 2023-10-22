namespace ReflectionLesson
{
    public class Student
    {
        private static int _id;
        public int Id { get; }

        static Student()
        {
            _id = 0;
        }

        public Student()
        {
            _id++;
            Id = _id;
        }
        public string Name { get; set; }

        public void ShowInfo() { }
    }
}
