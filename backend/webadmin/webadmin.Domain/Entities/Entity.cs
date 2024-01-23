namespace webadmin.Domain.Entities
{
    public abstract class Entity : IEquatable<Entity>
    {
        protected Entity()
        {
            Id = Guid.NewGuid();
            DateRegister = DateTime.Now;
        }
        
        public Guid Id { get; private set; }
        public DateTime? DateRegister { get; private set; }
        
        public bool Equals(Entity other) 
            => Id == other?.Id;

        // public void ConfirmationDateRegister() => DateRegister = DateTime.Now;
        
        public override int GetHashCode() 
            => (GetType().GetHashCode() * 907) + Id.GetHashCode();
    }
}
