using System.Reflection;
using Microsoft.EntityFrameworkCore;
using webadmin.Domain.Entities;

namespace webadmin.InfraStructure.Data.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { }

        #region DbSet

        public DbSet<User> User { get; set; }
        public DbSet<Customer> Customer { get; set; }

        #endregion DbSet

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }
    }
}
