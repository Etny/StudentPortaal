using System.ComponentModel.DataAnnotations;

namespace PortaalBackend.API.Models
{
    public class LoginInput
    {
        [EmailAddress]
        public string EmailAddress { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;
    }
}
