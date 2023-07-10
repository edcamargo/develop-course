using Microsoft.EntityFrameworkCore;
using webadmin.Domain.Core.Interfaces.Repositories;
using webadmin.Domain.Entities;
using webadmin.InfraStructure.Data.Context;

namespace webadmin.InfraStructure.Data.Repositories
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(DataContext context) : base(context)
        { }
    }
}
