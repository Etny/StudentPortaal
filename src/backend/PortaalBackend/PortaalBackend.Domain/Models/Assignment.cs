using PortaalBackend.Domain.Interfaces;
using PortaalBackend.Domain.Models.Joins;

namespace PortaalBackend.Domain.Models
{
    public record Assignment : IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime DateCreated { get; set; }
        public int CreatedById { get; set; }
        //public List<Attachment> Attachments { get; set; }
        public ICollection<AssignmentTag> AssignmentTags { get; set; } = new List<AssignmentTag>();
        public Ratings Ratings { get; set; } = new();
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
    }
}
