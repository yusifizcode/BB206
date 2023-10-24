namespace ClassTask.Exceptions
{
    public class PriceMustBeGratherThanZeroException : Exception
    {
        public PriceMustBeGratherThanZeroException() { }
        public PriceMustBeGratherThanZeroException(string message) : base(message) { }
    }
}
