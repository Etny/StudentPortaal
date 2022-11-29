using PortaalBackend.Domain.Models;

namespace PortaalBackend.Domain.Interfaces
{
    public interface IAssignmentService
    {
        public Task<Assignment> CreateAssignmentAsync(Assignment assignment);
        public Task<Comment> AddCommentAsync(Comment comment);
        public Assignment? GetById(int assignmentId);
        public List<Assignment> GetAll();
    }
}
