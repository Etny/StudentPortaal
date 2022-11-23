namespace PortaalBackend.Tests.AssignmentServiceTests;

[ExcludeFromCodeCoverage]
public class GetById
{
    private readonly AssignmentService assignmentService;
    private readonly Mock<IRepository<Assignment>> mockRepository;

    public GetById()
    {
        mockRepository = new Mock<IRepository<Assignment>>();
        assignmentService = new AssignmentService(mockRepository.Object);
    }


    [Fact]
    public void GetAssignment_Should_Call_Repository()
    {
        // Arrange
        Assignment input = new() { Id = -1 };
        mockRepository.Setup(y => y.Create(input)).ReturnsAsync(input);

        // Act
        Assignment? answer = assignmentService.GetById(-1);

        // Assert
        mockRepository.Verify(y => y.Create(input), Times.Once);
        Assert.Equal(input.Id, answer?.Id);
    }
}