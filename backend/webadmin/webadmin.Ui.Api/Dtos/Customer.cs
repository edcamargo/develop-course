namespace webadmin.Ui.Api.Dtos
{
    public record Customer
    {
        public string Name { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        //public User User { get; set; }
    }
}
