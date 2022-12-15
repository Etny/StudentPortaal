namespace PortaalBackend.Tests.TagServiceTests;

[ExcludeFromCodeCoverage]
public class DeleteGetById
{
    private readonly TagService tagService;
    private readonly Mock<IRepository<Tag>> mockRepository;

    public DeleteGetById()
    {
        mockRepository = new Mock<IRepository<Tag>>();
        tagService = new TagService(mockRepository.Object);
    }


    [Fact]
    public async Task Should_Call_Repository()
    {
        // Arrange
        Tag input = new() { Id = -1 };
        mockRepository.Setup(y => y.GetById(-1)).Returns(input);

        // Act
        await tagService.DeleteById(-1);

        // Assert
        mockRepository.Verify(y => y.DeleteById(-1), Times.Once);
    }
}