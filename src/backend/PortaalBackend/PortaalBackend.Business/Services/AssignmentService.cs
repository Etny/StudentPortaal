using PortaalBackend.Domain.Interfaces;
using PortaalBackend.Domain.Models;

namespace PortaalBackend.Business.Services
{

    public class AssignmentService : IAssignmentService
    {
        private readonly IRepository<Assignment> repository;

        public AssignmentService(IRepository<Assignment> repository)
        {
            this.repository = repository;
        }

        public async Task<Assignment> CreateAssignmentAsync(Assignment assignment)
        {
            assignment.DateCreated = DateTime.Now;
            Assignment createdAssignment = await repository.CreateAsync(assignment);
            await repository.SaveChangesAsync();
            return createdAssignment;
        }

        public Assignment? GetById(int assignmentId)
        {
            return repository.GetById(assignmentId);
        }

        public List<Assignment> GetAll()
        {
            return repository.GetAll().ToList();
        }
    }
}

