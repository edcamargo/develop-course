using Microsoft.EntityFrameworkCore;
using webadmin.Domain.Core.Interfaces.Repositories;
using webadmin.Domain.Entities;

namespace webadmin.InfraStructure.Data.Repositories
{
    public class CustomerRepository : RepositoryBase<Customer>, ICustomerRepository
    {
        public CustomerRepository(DbContext context) : base(context)
        { }
    }
}
