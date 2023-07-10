using AutoMapper;
using webadmin.Domain.Entities;
using webadmin.Ui.Api.Dtos;

namespace webadmin.Ui.Api.Configurations
{
    public class AutomapperConfig : Profile
    {
        public AutomapperConfig()
        {
            CreateMap<Customer, CustomerDto>().ReverseMap();

            //CreateMap<User, UserDto>().ReverseMap();
        }
    }
}
