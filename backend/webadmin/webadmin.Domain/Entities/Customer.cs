using FluentValidation;

namespace webadmin.Domain.Entities
{
    public class Customer : Entity
    {
        public Customer(string name, string city, string email, User user)
        {
            Name = name;
            City = city;
            Email = email;
            User = user;
        }

        public string Name { get; private set; }
        public string City { get; private set; }
        public string Email { get; private set; }
        public User User { get; private set; }
    }

    internal class CustomerValidation : AbstractValidator<Customer>
    {
        public static string NameErroMsg => "Nome inválido.";
        public static string CityErroMsg => "Salario inválido.";
        public static string EmailErroMsg => "E-mail inválido";
        public static string UserErroMsg => "Usuário inválido";

        public CustomerValidation()
        {
            RuleFor(c => c.Name)
                .NotEmpty()
                .WithMessage(NameErroMsg);

            RuleFor(c => c.City)
                .NotEmpty()
                .WithMessage(CityErroMsg);

            RuleFor(c => c.Email)
                .NotEmpty()
                .EmailAddress()
                .WithMessage(EmailErroMsg);

            RuleFor(c => c.User)
                .NotEmpty()
                .WithMessage(UserErroMsg);
        }
    }
}