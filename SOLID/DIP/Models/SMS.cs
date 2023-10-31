namespace DIP.Models
{
    internal class SMS : IMessageSender
    {
        public void Send()
        {
            Console.WriteLine("SMS sent from SMS service");
        }
    }
}
