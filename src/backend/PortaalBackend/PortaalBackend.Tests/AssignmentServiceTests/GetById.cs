namespace PortaalBackend.Tests.AssignmentServiceTests;

[ExcludeFromCodeCoverage]
public class GetById
{
    private readonly AssignmentService assignmentService;
    private readonly Mock<IRepository<Assignment>> mockRepository;
    private readonly Mock<IRepository<Comment>> mockCommentRepository;


    public GetById()
    {
        mockRepository = new Mock<IRepository<Assignment>>();
        mockCommentRepository = new Mock<IRepository<Comment>>();

        assignmentService = new AssignmentService(mockRepository.Object, mockCommentRepository.Object);
    }


    [Fact]
    public void Should_Call_Repository()
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
    public void Should_Return_Null_When_No_Assignment_Matches_Id()
    {
        // Arrange
        mockRepository.Setup(y => y.GetById(It.IsAny<int>())).Returns<Assignment>(null);

        // Act
        Assignment? answer = assignmentService.GetById(1);

        // Assert
        Assert.Null(answer);
    }
}