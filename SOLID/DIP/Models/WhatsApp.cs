namespace DIP.Models
{
    internal class WhatsApp : IMessageSender
    {
        public void Send()
        {
            Console.WriteLine("Whatsapp sent from Whatsapp service");
        }
    }
}
