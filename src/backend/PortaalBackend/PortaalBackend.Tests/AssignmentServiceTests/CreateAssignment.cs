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
    public async Task Should_Call_Repository()
    {
        // Arrange
        Assignment input = new() { Id = -1 };
        mockRepository.Setup(y => y.CreateAsync(input)).ReturnsAsync(input);

        // Act
        Assignment answer = await assignmentService.CreateAssignmentAsync(input);

        // Assert
        mockRepository.Verify(y => y.CreateAsync(input), Times.Once);
        Assert.Equal(input.Id, answer.Id);
    }
}