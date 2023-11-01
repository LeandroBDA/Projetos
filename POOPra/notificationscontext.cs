namespace POOPra
{
    public sealed class notificationscontext
    {
        public notificationscontext()
        {
            
        }

        public notificationscontext(string property, string message)
        {
            Property = property;
            Message = message;
        }
        public String Property { get; set; }
        public String Message { get; set; }
    }   
    
}

