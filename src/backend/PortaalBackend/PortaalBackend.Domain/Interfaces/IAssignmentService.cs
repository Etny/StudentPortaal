using PortaalBackend.Domain.Models;

namespace PortaalBackend.Domain.Interfaces
{
    public interface IAssignmentService
    {
        public Task<Assignment> CreateAssignment(Assignment assignment);
        public Task<Comment> AddCommentAsync(Comment comment);
        public Assignment? GetById(int assignmentId);
    }
}
