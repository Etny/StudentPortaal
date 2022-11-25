

namespace PortaalBackend.Domain.Models.Joins 
{
    //I am using this to create a many-to-many relationship ~Ynte
    public record AssignmentTag 
    {
        public int AssignmentId { get; set; }
        public Assignment Assignment { get; set; } = new();

        public int TagId { get; set; }
        public Tag Tag { get; set; } = new();
    }
}