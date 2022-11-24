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
    public void GetById_Should_Call_Repository()
    {
        // Arrange
        Assignment input = new() { Id = -1 };
        mockRepository.Setup(y => y.GetById(-1)).Returns(input);

        // Act
        Assignment? answer = assignmentService.GetById(-1);

        // Assert
        mockRepository.Verify(y => y.GetById(-1), Times.Once);
        Assert.Equal(input.Id, answer?.Id);
    }

    [Fact]
    public void GetById_Should_Return_Null_When_No_Assignment_Matches_Id()
    {
        // Arrange
        mockRepository.Setup(y => y.GetById(It.IsAny<int>())).Returns<Assignment>(null);

        // Act
        Assignment? answer = assignmentService.GetById(1);

        // Assert
        Assert.Null(answer);
    }
}