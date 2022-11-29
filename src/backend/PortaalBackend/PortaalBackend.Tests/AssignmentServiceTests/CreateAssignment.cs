namespace PortaalBackend.Tests.AssignmentServiceTests;

[ExcludeFromCodeCoverage]
public class CreateAssignment
{
    private readonly AssignmentService assignmentService;
    private readonly Mock<IRepository<Assignment>> mockRepository;
    private readonly Mock<IRepository<Comment>> mockCommentRepository;


    public CreateAssignment()
    {
        mockRepository = new Mock<IRepository<Assignment>>();
        mockCommentRepository = new Mock<IRepository<Comment>>();

        assignmentService = new AssignmentService(mockRepository.Object, mockCommentRepository.Object);
    }


    [Fact]
    public async Task CreateAssignment_Should_Call_Repository()
    {
        // Arrange
        Assignment input = new() { Id = -1 };
        mockRepository.Setup(y => y.Create(input)).ReturnsAsync(input);

        // Act
        Assignment answer = await assignmentService.CreateAssignment(input);

        // Assert
        mockRepository.Verify(y => y.Create(input), Times.Once);
        Assert.Equal(input.Id, answer.Id);
    }
}