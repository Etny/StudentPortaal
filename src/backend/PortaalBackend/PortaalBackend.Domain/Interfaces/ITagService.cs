using PortaalBackend.Domain.Models;

namespace PortaalBackend.Domain.Interfaces
{
    public interface ITagService
    {
        public Task<Tag> CreateTagAsync(Tag tag);
        public Tag? GetById(int assignmentId);
        public List<Tag> GetAll();
        public Task DeleteById(int id);
    }
}
