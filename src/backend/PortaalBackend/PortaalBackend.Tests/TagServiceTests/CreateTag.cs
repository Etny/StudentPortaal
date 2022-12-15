namespace PortaalBackend.Tests.TagServiceTests;

[ExcludeFromCodeCoverage]
public class CreateTag
{
    private readonly TagService tagService;
    private readonly Mock<IRepository<Tag>> mockRepository;

    public CreateTag()
    {
        mockRepository = new Mock<IRepository<Tag>>();
        tagService = new TagService(mockRepository.Object);
    }


    [Fact]
    public async Task Should_Call_Repository()
    {
        // Arrange
        Tag input = new() { Id = -1 };
        mockRepository.Setup(y => y.CreateAsync(input)).ReturnsAsync(input);

        // Act
        Tag answer = await tagService.CreateTagAsync(input);

        // Assert
        mockRepository.Verify(y => y.CreateAsync(input), Times.Once);
        Assert.Equal(input.Id, answer.Id);
    }
}