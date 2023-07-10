using Microsoft.Extensions.DependencyInjection;
using webadmin.Domain.Core.Interfaces.Repositories;
using webadmin.Domain.Core.Interfaces.Services;
using webadmin.Domain.Service.Services;
using webadmin.InfraStructure.Data.Repositories;

namespace webadmin.InfraStructure.Ioc
{
    public static class DependencyInjection
    {
        public static void DependencyInjectionServices(this IServiceCollection services)
        {
            //services.AddTransient<IUserService, UserService>();
            services.AddTransient<ICustomerService, CustomerService>();
        }

        public static void DependencyInjectionRepositories(this IServiceCollection services)
        {
            //services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
        }
    }
}
