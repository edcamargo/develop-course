using FluentValidation;
using System.Diagnostics.CodeAnalysis;

namespace webadmin.Domain.Entities
{
    [ExcludeFromCodeCoverage]
    public class User : Entity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        // Contrutores de sobrecarga
        public User(){ }
        public User(string name, string email, string password)
        {
            Name = name;
            Email = email;
            Password = password;
        }
    }

    internal class UserValidation : AbstractValidator<User>
    {
        public static string NameErroMsg => "Nome inválido.";
        public static string EmailErroMsg => "E-mail inválido";
        public static string PasswordErroMsg => "Senha inválido";

        public UserValidation()
        {
            RuleFor(c => c.Name)
                .NotEmpty()
                .WithMessage(NameErroMsg);

            RuleFor(c => c.Email)
                .NotEmpty()
                .EmailAddress()
                .WithMessage(EmailErroMsg);

            RuleFor(p => p.Password).NotEmpty().WithMessage("Sua senha não pode estar vazia")
                                    .MinimumLength(8).WithMessage("O tamanho da sua senha deve ser de pelo menos 8.")
                                    .MaximumLength(16).WithMessage("O tamanho da sua senha não deve exceder 16.")
                                    .Matches(@"[A-Z]+").WithMessage("Sua senha deve conter pelo menos uma letra maiúscula.")
                                    .Matches(@"[a-z]+").WithMessage("Sua senha deve conter pelo menos uma letra minúscula.")
                                    .Matches(@"[0-9]+").WithMessage("Sua senha deve conter pelo menos um número.")
                                    .Matches(@"[\!\?\*\.]+").WithMessage("Sua senha deve conter pelo menos um (!? *.).");
        }
    }
}
