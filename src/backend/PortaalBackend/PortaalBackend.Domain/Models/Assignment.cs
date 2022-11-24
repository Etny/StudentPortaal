using PortaalBackend.Domain.Interfaces;

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
        public List<Tag> Tags { get; set; } = new();
        public Ratings Ratings { get; set; } = new();
        public List<Comment> Comments { get; set; } = new();
    }
}
