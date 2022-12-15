
using System.Linq.Expressions;

namespace PortaalBackend.Tests.AssignmentServiceTests
{
    [ExcludeFromCodeCoverage]
    public class AddCommentTests
    {

        private readonly AssignmentService assignmentService;
        private readonly Mock<IRepository<Assignment>> mockRepository;
        private readonly Mock<IRepository<Comment>> mockCommentRepository;


        public AddCommentTests()
        {
            mockRepository = new Mock<IRepository<Assignment>>();
            mockCommentRepository = new Mock<IRepository<Comment>>();

            assignmentService = new AssignmentService(mockRepository.Object, mockCommentRepository.Object);
        }

        [Fact]
        public async Task Should_Check_Assignment_Id()
        {
            Comment noAssignmentId = new();

            await Assert.ThrowsAsync<ArgumentException>(async () => await assignmentService.AddCommentAsync(noAssignmentId));
        }

        [Fact]
        public async Task Should_Call_Repo()
        {
            mockRepository.Setup(m => m.GetById(It.IsAny<int>(), It.IsAny<Expression<Func<Assignment, object>>[]>())).Returns(new Assignment());
            Comment toBeCreated = new() { AssignmentId = 1 };

            await assignmentService.AddCommentAsync(toBeCreated);

            mockCommentRepository.Verify(m => m.CreateAsync(toBeCreated), Times.Once);
        }

    }
}