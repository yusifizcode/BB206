using ExceptionLesson.Excepptions;

namespace ExceptionLesson.Models
{
    public class Person
    {
        private sbyte _age;
        public string FullName { get; set; }
        public sbyte Age
        {
            get => _age;
            set
            {
                if (value > 0 && value < 125)
                {
                    _age = value;
                }
                else
                {
                    throw new InvalidAgeException("Yash duzgun daxil edilmeyib!!");
                }
            }
        }
    }
}
