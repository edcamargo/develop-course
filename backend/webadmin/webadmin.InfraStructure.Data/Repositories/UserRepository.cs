using Microsoft.EntityFrameworkCore;
using webadmin.Domain.Core.Interfaces.Repositories;
using webadmin.Domain.Entities;

namespace webadmin.InfraStructure.Data.Repositories
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(DbContext context) : base(context)
        { }
    }
}
