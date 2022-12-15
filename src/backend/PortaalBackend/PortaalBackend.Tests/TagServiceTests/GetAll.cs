namespace PortaalBackend.Tests.TagServiceTests;

[ExcludeFromCodeCoverage]
public class GetAll 
{
    private readonly TagService tagService;
    private readonly Mock<IRepository<Tag>> mockRepository;

    public GetAll()
    {
        mockRepository = new Mock<IRepository<Tag>>();
        tagService = new TagService(mockRepository.Object);
    }

    [Fact]
    public void GetAll_Should_Use_Repo()
    {
        // Arrange
        Tag testTag = new() { Id = 10 };
        List<Tag> allTags = new() { testTag };
        mockRepository.Setup(r => r.GetAll()).Returns(allTags.AsQueryable());

        // Act
        List<Tag> all = tagService.GetAll();

        // Assert
        mockRepository.Verify(y => y.GetAll(), Times.Once);
        Assert.True(all.SequenceEqual(allTags));
    }
}