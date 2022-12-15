using PortaalBackend.Domain.Interfaces;
using System.Diagnostics.CodeAnalysis;

namespace PortaalBackend.Domain.Models
{
    [ExcludeFromCodeCoverage]
    public record Rating : IEntity
    {
        public int Id { get; set; }
        public double Rated { get; set; }
        public int RatedById { get; set; }
        public int AssignmentId { get; set; }
    }
}
