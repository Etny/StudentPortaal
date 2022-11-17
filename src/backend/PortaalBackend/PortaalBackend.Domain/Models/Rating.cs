using PortaalBackend.Domain.Interfaces;

namespace PortaalBackend.Domain.Models
{
    public record Rating : IEntity
    {
        public int Id { get; set; }
        public double Rated { get; set; }
        public int RatedById { get; set; }
    }
}
