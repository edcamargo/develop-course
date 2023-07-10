namespace webadmin.Ui.Api.Dtos
{
    public record CustomerDto
    {
        public string? Name { get; set; }
        public string? City { get; set; }
        public string? Email { get; set; }
        public UserDto? user { get; set; }
    }
}
