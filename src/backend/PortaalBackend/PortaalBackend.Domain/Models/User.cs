using PortaalBackend.Domain.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace PortaalBackend.Domain.Models
{
    [ExcludeFromCodeCoverage]
    public record User : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;

        [NotMapped]
        public string FullName => FirstName + " " + LastName;

        public string Email { get; set; } = string.Empty;
        public int? CreatedById { get; set; }
        public User? CreatedBy { get; set; }
    }
}
