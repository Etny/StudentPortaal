namespace PortaalBackend.Tests.UserServiceTests;

[ExcludeFromCodeCoverage]
public class CreateUser
{
    private readonly UserService userService;
    private readonly Mock<IRepository<User>> mockRepository;

    public CreateUser()
    {
        mockRepository = new Mock<IRepository<User>>();
        userService = new UserService(mockRepository.Object);
    }


    [Fact]
    public async Task Should_Call_Repository()
    {
        // Arrange
        User input = new() { Id = -1 };
        mockRepository.Setup(y => y.Create(input)).ReturnsAsync(input);

        // Act
        User answer = await userService.CreateUser(input);

        // Assert
        mockRepository.Verify(y => y.Create(input), Times.Once);
        Assert.Equal(input.Id, answer.Id);
    }
}