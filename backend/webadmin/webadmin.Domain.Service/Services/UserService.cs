using webadmin.Domain.Core.Interfaces.Repositories;
using webadmin.Domain.Core.Interfaces.Services;
using webadmin.Domain.Entities;

namespace webadmin.Domain.Service.Services
{
    public class UserService : ServiceBase<User>, IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository) : base(userRepository)
        {
            _userRepository = userRepository;
        }
    }
}
