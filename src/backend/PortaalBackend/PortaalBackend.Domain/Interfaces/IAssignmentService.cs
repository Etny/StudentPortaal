using PortaalBackend.Domain.Models;

namespace PortaalBackend.Domain.Interfaces
{
    public interface IAssignmentService
    {
        public Task<Assignment> CreateAssignmentAsync(Assignment assignment);
        public Assignment? GetById(int assignmentId);
        public List<Assignment> GetAll();
    }
}
