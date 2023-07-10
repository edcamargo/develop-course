using AutoMapper;
using webadmin.Domain.Core.Interfaces.Repositories;
using webadmin.Domain.Core.Interfaces.Services;
using webadmin.Domain.Entities;

namespace webadmin.Domain.Service.Services
{
    public class CustomerService : ServiceBase<Customer>, ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;

        public CustomerService(ICustomerRepository customerRepository, 
                               IMapper mapper) : base(customerRepository)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
        }
    }
}
