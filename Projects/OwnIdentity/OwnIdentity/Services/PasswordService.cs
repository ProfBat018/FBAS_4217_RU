namespace OwnIdentity.Services;

public static class PasswordService
{
    public static string HashPassword(string? password)
    {
        if (password == null)
            throw new ArgumentNullException(nameof(password));

        return BCrypt.Net.BCrypt.HashPassword(password);
    }
    
    public static bool VerifyPassword(string? password, string? hashedPassword)
    {
        if (password == null || hashedPassword == null)
            throw new ArgumentNullException(nameof(password));

        return BCrypt.Net.BCrypt.Verify(password, hashedPassword);
    }
    
}