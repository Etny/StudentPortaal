using PortaalBackend.Domain.Models;

namespace PortaalBackend.Domain.Interfaces
{
    public interface IAssignmentService
    {
        public Task<Assignment> CreateAssignment(Assignment assignment);
    }
}
