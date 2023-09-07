using JWT.Services;

namespace JWT.Models;

public class RegisterViewModel
{
    public AccountLoginViewModel AccountLoginViewModel { get; set; }
    public string ConfirmPassword { get; set; }
}