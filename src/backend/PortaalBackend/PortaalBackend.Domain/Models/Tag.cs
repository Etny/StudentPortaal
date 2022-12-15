using PortaalBackend.Domain.Interfaces;
using PortaalBackend.Domain.Models.Joins;
using System.Diagnostics.CodeAnalysis;

namespace PortaalBackend.Domain.Models
{
    [ExcludeFromCodeCoverage]
    public record Tag : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = "New_Tag";
        public ICollection<AssignmentTag> AssignmentTags { get; set; } = new List<AssignmentTag>();
    }
}
