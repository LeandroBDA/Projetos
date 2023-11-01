namespace POOPra
{
    public abstract class notifiable
    {
        public List<notifiable> Notifications { get; set; }

        public void Add(notifiable notification)
        {
            Notifications.Add(notification);
        }

        public void AddRange(IEnumerable<notifiable> notifications)
        {
            Notifications = (List<notifiable>)notifications;
        }
    }
}

