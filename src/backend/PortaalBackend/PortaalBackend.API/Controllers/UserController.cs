using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PortaalBackend.API.Models;
using PortaalBackend.API.Tokens;
using PortaalBackend.Domain.Interfaces;

namespace PortaalBackend.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ITokenService tokenService;
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;
        private readonly IUserService userService;

        public UserController(ITokenService tokenService, UserManager<IdentityUser> userManager,
                              SignInManager<IdentityUser> signInManager, IUserService userService)
        {
            this.tokenService = tokenService;
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.userService = userService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginInput loginInput)
        {
            Microsoft.AspNetCore.Identity.SignInResult result = await signInManager.PasswordSignInAsync(loginInput.EmailAddress, loginInput.Password, false, false);

            if (result.Succeeded)
            {
                IdentityUser user = await userManager.FindByNameAsync(loginInput.EmailAddress);
                IList<string> roles = await userManager.GetRolesAsync(user);

                string newToken;
                if (roles.Contains("Student"))
                    newToken = tokenService.GenerateToken(user, "Student");
                else if (roles.Contains("Teacher"))
                    newToken = tokenService.GenerateToken(user, "Teacher");
                else if (roles.Contains("Admin"))
                    newToken = tokenService.GenerateToken(user, "Admin");
                else
                    return Unauthorized("Invalid Role");

                return Accepted(newToken);

            }

            return Unauthorized("Invalid login");
        }
    }
}
