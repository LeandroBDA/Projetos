
namespace POOPra
{
    public abstract class Base : notifiable
    {
        public Base()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
    }
}

