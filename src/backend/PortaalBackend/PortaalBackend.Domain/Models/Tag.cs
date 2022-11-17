using PortaalBackend.Domain.Interfaces;

namespace PortaalBackend.Domain.Models
{
    public record Tag : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = "New_Tag";
    }
}
