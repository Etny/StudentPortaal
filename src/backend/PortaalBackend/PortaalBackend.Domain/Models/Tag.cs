using PortaalBackend.Domain.Interfaces;
using PortaalBackend.Domain.Models.Joins;

namespace PortaalBackend.Domain.Models
{
    public record Tag : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = "New_Tag";
        public ICollection<AssignmentTag> AssignmentTags { get; set; } = new List<AssignmentTag>();
    }
}
