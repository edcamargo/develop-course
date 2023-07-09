using webadmin.Domain.Core.Interfaces.Repositories;
using webadmin.Domain.Core.Interfaces.Services;
using webadmin.Domain.Entities;

namespace webadmin.Domain.Service.Services
{
    public class CustomerService : ServiceBase<Customer>, ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository) : base(customerRepository)
        {
            _customerRepository = customerRepository;
        }
    }
}
