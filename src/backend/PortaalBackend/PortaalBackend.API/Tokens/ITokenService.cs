using Microsoft.AspNetCore.Identity;

namespace PortaalBackend.API.Tokens
{
    public interface ITokenService
    {
        string GenerateToken(IdentityUser user, string role);
    }
}
