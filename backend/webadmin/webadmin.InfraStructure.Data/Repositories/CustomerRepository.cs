using Microsoft.EntityFrameworkCore;
using webadmin.Domain.Core.Interfaces.Repositories;
using webadmin.Domain.Entities;
using webadmin.InfraStructure.Data.Context;

namespace webadmin.InfraStructure.Data.Repositories
{
    public class CustomerRepository : RepositoryBase<Customer>, ICustomerRepository
    {
        public CustomerRepository(DataContext context) : base(context)
        { }
    }
}
