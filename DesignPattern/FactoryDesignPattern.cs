using System;
namespace DesignPattern
{
    public interface INotification
    {
        void notifyUser();

    }
    class EmailNotification : INotification
    {
        public void notifyUser()
        {
            Console.WriteLine("Send email notification");
        }
    }
    class MessageNotification : INotification
    {
        public void notifyUser()
        {
            Console.WriteLine("Send message notification");
        }
    }
    class PushNotification : INotification
    {
        public void notifyUser()
        {
            Console.WriteLine("Send push notification");
        }
    }
    public class FactoryDesignPattern
    {
        public FactoryDesignPattern()
        {
        }

        public INotification getObject(string channel)
        {
            if (channel == null || channel.Length < 0)
                return null;
            if ("SMS".Equals(channel))
            {
                return new MessageNotification();
            }
            else if ("EMAIL".Equals(channel))
            {
                return new EmailNotification();
            }
            else if ("PUSH".Equals(channel))
            {
                return new PushNotification();
            }
            return null;

        }
    }
}
