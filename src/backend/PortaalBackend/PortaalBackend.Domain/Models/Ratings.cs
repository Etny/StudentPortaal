using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace PortaalBackend.Domain.Models
{
    [ExcludeFromCodeCoverage]
    [Owned]
    public record Ratings
    {
        public double Highest { get; set; }
        public double Lowest { get; set; }
        public double Average { get; set; }

        [NotMapped]
        public List<Rating> AllRatings { get; set; } = new();
    }
}
