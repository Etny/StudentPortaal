
namespace PortaalBackend.Domain.Models.Joins
{
    public record AssignmentComment
    {
        public int AssignmentId { get; set; }
        public Assignment Assignment { get; set; } = new();

        public int CommentId { get; set; }
        public Comment Comment { get; set; } = new();
    }
}