using DIP.Models;

namespace DIP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMessageSender emailService = new Email();

            //emailService.Send();

            SMS sMS = new SMS();
            //sMS.Send();

            List<IMessageSender> messageSenders = new List<IMessageSender>();
            messageSenders.Add(emailService);
            messageSenders.Add(sMS);
            messageSenders.Add(new WhatsApp());

            MessageSender messageSender = new MessageSender(messageSenders);

            messageSender.Send();
        }
    }
}