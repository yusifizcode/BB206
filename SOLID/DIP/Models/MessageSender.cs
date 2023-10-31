namespace DIP.Models
{
    internal class MessageSender
    {
        //Email _email;
        //SMS _sms;
        //WhatsApp _whatsApp;

        List<IMessageSender> _messages;

        public MessageSender(List<IMessageSender> messageSenders)
        {
            _messages = messageSenders;
        }

        public void Send()
        {
            foreach (var item in _messages)
            {
                item.Send();
            }
        }
    }
}
