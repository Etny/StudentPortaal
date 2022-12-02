using System.Text.Json.Serialization;
using PortaalBackend.Domain.Interfaces;
using PortaalBackend.Domain.Models.Joins;

namespace PortaalBackend.Domain.Models
{

    public record Comment : IEntity
    {
        public int Id { get; set; }
        public int AssignmentId { get; set; }
        [JsonIgnore]
        public Assignment? Assignment { get; set; } = null;
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int CreatorId { get; set; }
        public string Content { get; set; } = string.Empty;

    }
}
