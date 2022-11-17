using PortaalBackend.Domain.Interfaces;

namespace PortaalBackend.Domain.Models
{

    public record Comment : IEntity
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string Content { get; set; } = string.Empty;
    }
}
