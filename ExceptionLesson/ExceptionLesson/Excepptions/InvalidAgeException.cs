namespace ExceptionLesson.Excepptions
{
    public class InvalidAgeException : Exception
    {
        public InvalidAgeException() { }

        public InvalidAgeException(string message) : base(message) { }
    }
}
