namespace webadmin.Domain.Entities
{
    public abstract class Entity : IEquatable<Entity>
    {
        protected Entity()
        {
            Id = Guid.NewGuid();
            DateRegister = null;
        }
        public Guid Id { get; private set; }
        public DateTime? DateRegister { get; private set; }
        public bool Equals(Entity other)
        {
            return Id == other.Id;
        }
        public void ConfirmationIntegration()
        {
            DateRegister = DateTime.Now;
        }
        public override int GetHashCode()
        {
            return (GetType().GetHashCode() * 907) + Id.GetHashCode();
        }
    }
}
