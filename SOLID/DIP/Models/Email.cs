namespace DIP.Models
{
    internal class Email : IMessageSender
    {
        public void Send()
        {
            Console.WriteLine("Email sent from Email service");
        }
    }
}
