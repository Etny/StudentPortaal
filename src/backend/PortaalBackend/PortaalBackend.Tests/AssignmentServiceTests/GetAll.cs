namespace PortaalBackend.Tests.AssignmentServiceTests;

[ExcludeFromCodeCoverage]
public class GetAll 
{
    private readonly AssignmentService assignmentService;
    private readonly Mock<IRepository<Comment>> mockCommentRepo;
    private readonly Mock<IRepository<Assignment>> mockRepo;

    public GetAll()
    {
        mockRepo = new Mock<IRepository<Assignment>>();
        mockCommentRepo = new Mock<IRepository<Comment>>();
        assignmentService = new AssignmentService(mockRepo.Object, mockCommentRepo.Object);
    }

    [Fact]
    public void GetAll_Should_Use_Repo()
    {
        // Arrange
        Assignment testAssignment = new() { Id = 10 };
        List<Assignment> allAssignments = new() { testAssignment };
        mockRepo.Setup(r => r.GetAll()).Returns(allAssignments.AsQueryable());

        // Act
        List<Assignment> all = assignmentService.GetAll();

        // Assert
        mockRepo.Verify(y => y.GetAll(), Times.Once);
        Assert.True(all.SequenceEqual(allAssignments));
    }
}