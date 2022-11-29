using PortaalBackend.Domain.Interfaces;
using PortaalBackend.Domain.Models;

namespace PortaalBackend.Business.Services
{

    public class AssignmentService : IAssignmentService
    {
        private readonly IRepository<Assignment> assignmentRepo;
        private readonly IRepository<Comment> commentRepo;

        public AssignmentService(IRepository<Assignment> repository, IRepository<Comment> commentRepo)
        {
            this.assignmentRepo = repository;
            this.commentRepo = commentRepo;
        }

        public async Task<Assignment> CreateAssignmentAsync(Assignment assignment)
        {
            assignment.DateCreated = DateTime.Now;
            Assignment createdAssignment = await assignmentRepo.CreateAsync(assignment);
            await assignmentRepo.SaveChangesAsync();
            return createdAssignment;
        }

        public async Task<Comment> AddCommentAsync(Comment comment)
        {
            if (GetById(comment.AssignmentId) == null) throw new ArgumentException("No valid AssignmentId provided");

            Comment result = await commentRepo.CreateAsync(comment);
            return result;
        }

        public Assignment? GetById(int assignmentId)
        {
            return assignmentRepo.GetById(assignmentId);
        }

        public List<Assignment> GetAll()
        {
            return assignmentRepo.GetAll().ToList();
        }
    }
}

