namespace PortaalBackend.Tests.TagServiceTests;

[ExcludeFromCodeCoverage]
public class GetById
{
    private readonly TagService tagService;
    private readonly Mock<IRepository<Tag>> mockRepository;

    public GetById()
    {
        mockRepository = new Mock<IRepository<Tag>>();
        tagService = new TagService(mockRepository.Object);
    }


    [Fact]
    public void Should_Call_Repository()
    {
        // Arrange
        Tag input = new() { Id = -1 };
        mockRepository.Setup(y => y.GetById(-1)).Returns(input);

        // Act
        Tag? answer = tagService.GetById(-1);

        // Assert
        mockRepository.Verify(y => y.GetById(-1), Times.Once);
        Assert.Equal(input.Id, answer?.Id);
    }

    [Fact]
    public void Should_Return_Null_When_No_Tag_Matches_Id()
    {
        // Arrange
        mockRepository.Setup(y => y.GetById(It.IsAny<int>())).Returns<Tag>(null);

        // Act
        Tag? answer = tagService.GetById(1);

        // Assert
        Assert.Null(answer);
    }
}