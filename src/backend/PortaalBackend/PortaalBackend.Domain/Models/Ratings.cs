using Microsoft.EntityFrameworkCore;

namespace PortaalBackend.Domain.Models
{
    [Owned]
    public record Ratings
    {
        public double Highest { get; set; }
        public double Lowest { get; set; }
        public double Average { get; set; }
        public List<Rating> AllRatings { get; set; } = new();
    }
}
