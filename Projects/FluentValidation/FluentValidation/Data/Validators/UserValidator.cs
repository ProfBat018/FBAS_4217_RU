using FluentValidation;
using FluentValidationExample.Data.Models;
using System.Text.RegularExpressions;

namespace FluentValidationExample.Data.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        private readonly static string nameMsg;
        private readonly static string emailMsg;
        private readonly static string passwordMsg;


        public UserValidator()
        {
            RuleFor(u => u.Name).Must(CheckName).WithMessage(nameMsg);
            RuleFor(u => u.Email).Must(CheckEmail).WithMessage(emailMsg);
            RuleFor(u => u.Password).Must(CheckPassword).WithMessage(passwordMsg);
        }

        static UserValidator()
        {
            nameMsg = "Name must be between 1 and 30 characters and contain only letters.";
            emailMsg = "Email must be between 1 and 30 characters and contain only letters.";
            passwordMsg = "Password must be between 8 and 16 characters and contain at least one uppercase letter, one lowercase letter, one number and one special character.";
        }


        public static bool CheckName(string? name) {
            Regex re = new(@"^[A-Z][a-z]");
            return name != null && name.Length > 0 && name.Length <= 30 && re.IsMatch(name);
        }

        public static bool CheckEmail(string? email)
        {
            Regex re = new(@"(([a-zA-Z0-9](\.|_)?)+([a-zA-Z0-9])+@([a-zA-Z0-9])+((\.)[a-zA-Z]{2,})+)");
            return email != null && email.Length > 0 && email.Length <= 30 && re.IsMatch(email);
        }
        public static bool CheckPassword(string? password)
        {
            Regex re = new(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&_*-]).{8,}$");
            return password != null && password.Length > 8 && password.Length <= 16 && re.IsMatch(password);
        }
    }
}
