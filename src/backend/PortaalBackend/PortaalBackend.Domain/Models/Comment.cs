using PortaalBackend.Domain.Interfaces;
using PortaalBackend.Domain.Models.Joins;

namespace PortaalBackend.Domain.Models
{

    public record Comment : IEntity
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string Content { get; set; } = string.Empty;
        public ICollection<AssignmentComment> AssignmentComments { get; set; } = new List<AssignmentComment>();

    }
}
