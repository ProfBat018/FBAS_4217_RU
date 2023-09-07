using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace JWT.Services;


public class Authentication
{
// Generate token
    public static string GenerateJwtToken(string username, List<string> roles)
    {
        var claims = new List<Claim>
        {
            new Claim(JwtRegisteredClaimNames.Sub, username),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()), new Claim(ClaimTypes.NameIdentifier,            username);
        };

        roles.ForEach(role =>
        {
            
        });
    }
}