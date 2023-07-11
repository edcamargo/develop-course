using webadmin.Domain.Entities;

namespace webadmin.Ui.Api.Dtos
{
    public record CustomerDto
    {
        public string Name { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public User user { get; set; }
    }
}
